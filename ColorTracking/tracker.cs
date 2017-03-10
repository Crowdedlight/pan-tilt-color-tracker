using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.Threading;
using System.IO;
using System.IO.Ports;

namespace ColorTracking
{
    public partial class tracker : Form
    {
        string d = "";
        private FilterInfoCollection videoDevices;
        EuclideanColorFiltering filter = new EuclideanColorFiltering();
        Color color = Color.Black;
        GrayscaleBT709 grayscaleFilter = new GrayscaleBT709();
        BlobCounter blobCounter = new BlobCounter();
        int range = 120;
        string rxData = "";

        public tracker()
        {
            InitializeComponent();
           
            blobCounter.MinWidth = 2;
            blobCounter.MinHeight = 2;
            blobCounter.FilterBlobs = true;
            blobCounter.ObjectsOrder = ObjectsOrder.Size;
            try
            {
                // enumerate video devices
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                //Enumerate serial ports
                var ports = SerialPort.GetPortNames();
                uartCombo.DataSource = ports;

                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                // add all devices to combo
                foreach (FilterInfo device in videoDevices)
                {
                    camerasCombo.Items.Add(device.Name);
                }

                camerasCombo.SelectedIndex = 0;
            }
            catch (ApplicationException)
            {
                camerasCombo.Items.Add("No local capture devices");
                videoDevices = null;
            }

            Bitmap b = new Bitmap(320, 240);
           // Rectangle a = (Rectangle)r;
            Pen pen1 = new Pen(Color.FromArgb(160, 255, 160), 3);
            Graphics g2 = Graphics.FromImage(b);
            pen1 = new Pen(Color.FromArgb(255, 0, 0), 3);
            g2.Clear(Color.White);
            g2.DrawLine(pen1, b.Width / 2, 0, b.Width / 2, b.Width);
            g2.DrawLine(pen1, b.Width, b.Height / 2, 0, b.Height / 2); 
            pictureBox1.Image = (System.Drawing.Image)b;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        
        }

        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            Bitmap objectsImage = null;
            Bitmap mImage = null;
            mImage=(Bitmap)image.Clone();            
            filter.CenterColor = new RGB(Color.FromArgb(color.ToArgb()));
            filter.Radius =(short)range;
           
            objectsImage = image;
            filter.ApplyInPlace(objectsImage);

            BitmapData objectsData = objectsImage.LockBits(new Rectangle(0, 0, image.Width, image.Height),
            ImageLockMode.ReadOnly, image.PixelFormat);
            UnmanagedImage grayImage = grayscaleFilter.Apply(new UnmanagedImage(objectsData));
            objectsImage.UnlockBits(objectsData);

            
            blobCounter.ProcessImage(grayImage);
            Rectangle[] rects = blobCounter.GetObjectsRectangles();
           
            if (rects.Length > 0)
            {

                foreach (Rectangle objectRect in rects)
                {
                    Graphics g = Graphics.FromImage(mImage);
                    using (Pen pen = new Pen(Color.FromArgb(160, 255, 160), 5))
                    {
                        g.DrawRectangle(pen, objectRect);
                    }

                    g.Dispose();
                }
            }

            image = mImage;
        }
        private void videoSourcePlayer3_NewFrame(object sender, ref Bitmap image)
        {
            Bitmap objectsImage = null;
      
                
                  // set center colol and radius
                  filter.CenterColor = new RGB(Color.FromArgb(color.ToArgb()));
                  filter.Radius = (short)range;
                  // apply the filter
                  objectsImage = image;
                  filter.ApplyInPlace(image);

            // lock image for further processing
            BitmapData objectsData = objectsImage.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadOnly, image.PixelFormat);

            // grayscaling
            UnmanagedImage grayImage = grayscaleFilter.Apply(new UnmanagedImage(objectsData));

            // unlock image
            objectsImage.UnlockBits(objectsData);

            // locate blobs 
            blobCounter.ProcessImage(grayImage);
            Rectangle[] rects = blobCounter.GetObjectsRectangles();
          
            if (rects.Length > 0)
            {
                Rectangle objectRect = rects[0];

                // draw rectangle around derected object
                Graphics g = Graphics.FromImage(image);

                using (Pen pen = new Pen(Color.FromArgb(160, 255, 160), 5))
                {
                    g.DrawRectangle(pen, objectRect);
                }
              g.Dispose();
                int objectX = objectRect.X + objectRect.Width / 2 - image.Width / 2;
                int objectY = image.Height / 2 - (objectRect.Y + objectRect.Height / 2);
                ParameterizedThreadStart t = new ParameterizedThreadStart(p);
               Thread aa = new Thread(t);
               aa.Start(rects[0]);               
            }
            Graphics g1 = Graphics.FromImage(image);
            Pen pen1 = new Pen(Color.FromArgb(160, 255, 160), 3);
            g1.DrawLine(pen1,image.Width/2,0,image.Width/2,image.Width);
            g1.DrawLine(pen1, image.Width , image.Height / 2, 0, image.Height / 2);
            g1.Dispose();
       }

  


   void p(object r)
   {
       try
       {

            Bitmap b = new Bitmap(pictureBox1.Image);
            Rectangle a = (Rectangle)r;
            Pen pen1 = new Pen(Color.FromArgb(160, 255, 160), 3);
            Graphics g2 = Graphics.FromImage(b);
            pen1 = new Pen(color, 3);
            // Brush b5 = null;
            SolidBrush b5 = new SolidBrush(Color.Red);
            //   g2.Clear(Color.Black);


            Font f = new Font(Font, FontStyle.Bold);

            //Change coords to center coords
            int centerX = a.Location.X + (a.Size.Width / 2);
            int centerY = a.Location.Y + (a.Size.Height / 2);

            //Delta Coords from center
            int deltaX = centerX - (320 / 2);
            int deltaY = centerY - (240 / 2);

            //Change to grades. 1x = 3,55 degress = 45deg window each side.  1y = 2,66 degree
            //Not correct atm... It needs to be made the new setpoint. so need to know starting position/last position
            double degreeX = deltaX * 3.55 * 10;
            double degreeY = deltaY * 2.66 * 10;

            string setPan = string.Format("SP{0};", (int)degreeX);
            string setTilt = string.Format("ST{0};", (int)degreeY);

            string msg = setPan + setTilt;

            g2.DrawString("o", f, b5, centerX, centerY);
            g2.Dispose();
            pictureBox1.Image = (System.Drawing.Image)b;
            this.Invoke((MethodInvoker)delegate
                {
                    string centerLoc = "{x=" + centerX + "," + "y=" + centerY + "}";
                    string deltaLoc = "{x=" + deltaX + "," + "y=" + deltaY + "}";
                    string degreeLoc = "{x=" + degreeX+ "," + "y=" + degreeY + "}";
                    richTextBox1.Text =  centerLoc + "      " + deltaLoc + "      " + degreeLoc + "\n" + richTextBox1.Text + "\n";

                    if(uart.IsOpen)
                    {
                        //Send uart msg
                        uart.Write(msg);

                        //Show in local textbox
                        uartsendTxtBox.Text = msg + "\n" + uartsendTxtBox.Text + "\n";
                    }
                });
       }
       catch (Exception faa)
       {
           Thread.CurrentThread.Abort();
       }


       Thread.CurrentThread.Abort();
   }

        public void Connect(string portname)
        {
            uart.PortName = portname;
            if(!uart.IsOpen)
            {
                uart.BaudRate = 38400;
                uart.DataBits = 8;
                uart.Parity = Parity.None;
                uart.StopBits = StopBits.One;
                uart.Open();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
            videoSourcePlayer3.SignalToStop();
            videoSourcePlayer3.WaitForStop();
            // videoDevices = null;
            VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[camerasCombo.SelectedIndex].MonikerString);
            videoSource.DesiredFrameSize = new Size(320, 240);
            videoSource.DesiredFrameRate = 12;

            videoSourcePlayer1.VideoSource = videoSource;
            videoSourcePlayer1.Start();
            videoSourcePlayer3.VideoSource = videoSource;
            videoSourcePlayer3.Start();
            //groupBox1.Enabled = false;
            uartStart.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void f21_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
            videoSourcePlayer3.SignalToStop();
            videoSourcePlayer3.WaitForStop();
            groupBox1.Enabled = true;

            //Uart stop
            if (uart.IsOpen)
                uart.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
            videoSourcePlayer3.SignalToStop();
            videoSourcePlayer3.WaitForStop();
            button1.Enabled = true;
            button2.Enabled = false;
            //Stop Uart
            uartStop_Click(uartStop, EventArgs.Empty);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            colorDialog1.ShowDialog();
            color = colorDialog1.Color;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            range = Convert.ToInt32(numericUpDown1.Value) ;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            blobCounter.MaxWidth = Convert.ToInt32(numericUpDown2.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            blobCounter.MinWidth  = Convert.ToInt32(numericUpDown3.Value);
        }

        private void uartStart_Click(object sender, EventArgs e)
        {
            //Open connection if correct port is chosen
            if(uartCombo.SelectedIndex > -1)
            {

                Connect(uartCombo.SelectedValue.ToString());
                uartStart.Enabled = false;
                uartStop.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please select a port first");
            }
        }

        private void uartStop_Click(object sender, EventArgs e)
        {
            if(uart.IsOpen)
            {
                uart.Close();
                uartStart.Enabled = true;
                uartStop.Enabled = false;
            }
        }

        private void tracker_Load(object sender, EventArgs e)
        {

        }

        private void uart_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            rxData = uart.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));
        }

        private void DisplayText(object sender, EventArgs e)
        {
            //Nothing atm
        }

        private void clearPlotBtn_Click_1(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(pictureBox1.Image);
            Graphics g2 = Graphics.FromImage(b);
            g2.Clear(Color.White);
            Pen pen1 = new Pen(Color.FromArgb(255, 0, 0), 3);
            g2.DrawLine(pen1, b.Width / 2, 0, b.Width / 2, b.Width);
            g2.DrawLine(pen1, b.Width, b.Height / 2, 0, b.Height / 2);
            g2.Dispose();
            pictureBox1.Image = (System.Drawing.Image)b;
        }
    }
}
