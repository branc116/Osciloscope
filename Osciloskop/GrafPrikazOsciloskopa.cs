using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Osciloskop
{
    public partial class GrafPrikazOsciloskopa : Control
    {
        Point[] buffer;
        SerialPort esp;
        protected int _zoom = 50;
        string buf = string.Empty;
        protected int cycle = 0;
        public int zoom
        {
            get
            {
                return _zoom;
            }
            set
            {
                _zoom = value;
                Invalidate();
            }
        }
        bool trea=true;
        void tmr()
        {
            while (true)
            {
                trea = true;
                Thread.Sleep(60);
            }
        }
        public GrafPrikazOsciloskopa()
        {
            InitializeComponent();
            esp = new SerialPort("COM3", 9600,Parity.None,8,StopBits.One);
            esp.DataReceived += Esp_DataReceived;
            new Thread(new ThreadStart(tmr)).Start();
        }

        private void Esp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            buf += sp.ReadExisting();
            string[] coms = buf.Split(new string[1] {
                "\r\n"
                 }, StringSplitOptions.RemoveEmptyEntries
            );
            if (coms.Length > 2)
            {
                foreach (string com in coms)
                {
                    //Console.WriteLine("Resive = " + com);
                    try
                    {
                        if (com.Length > 4 && com.Substring(0, 4) == "vl =")
                        {
                            int rawNum = Convert.ToInt32(com.Substring(4, com.Length - 4));
                            float dec = rawNum / 1500f;
                            dec = 1f - dec;
                            int convertedNum = (int)(dec * Height) - 20;
                            buffer[cycle].Y = convertedNum;

                            cycle = (cycle + 1) % Width;
                        }
                        else
                        {
                            Console.WriteLine(com);
                        }
                    }
                    catch { }
                    buf = string.Empty;
                }
                
               Invalidate();
            }
        }
        public void RebootEsp()
        {
            if (esp.IsOpen)
                esp.WriteLine ("node.restart()");
            else
                Console.WriteLine("Not Connected");
        }
        public void DisconnectEsp()
        {
            if (esp.IsOpen)
                esp.Close();
            else
                Console.WriteLine("Not Open");
        }
        public void OpenEsp()
        {
            if (esp.IsOpen)
                Console.WriteLine("Alredy Open");
            else
                esp.Open();
        }
        public void ChangeFrequencyEsp(int num)
        {
            if (esp.IsOpen)
                esp.WriteLine("a=" + num.ToString());
            else
                Console.WriteLine("Not Open");
        }
        public void StartOsciOnEsp()
        {
            if (esp.IsOpen)
                esp.WriteLine("dofile(\"Osciloskop.lua\")");
            else
                Console.WriteLine("Not Open");

        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            if (trea || true)
            {
                trea = false;
                base.OnPaint(pe);
                Graphics gr = CreateGraphics();
                gr.Clear(Color.Wheat);
                Pen myPen = new Pen(Brushes.Black, 2f);
                int n = (Size.Height - 10) / zoom;
                Point[] koord = new Point[2 * n];
                gr.DrawRectangle(myPen, new Rectangle(0, 0, Width, Height));
                myPen.Width = 0.1f;
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        koord[2 * i] = new Point(0, (n - i) * zoom + 10);
                        koord[2 * i + 1] = new Point(Width, (n - i) * zoom + 10);
                    }
                    else
                    {
                        koord[2 * i] = new Point(Width, (n - i) * zoom + 10);
                        koord[2 * i + 1] = new Point(0, (n - i) * zoom + 10);
                    }
                }
                if (n > 0)
                    gr.DrawLines(myPen, koord);
                myPen.Width = 4f;
                myPen.Color = Color.DarkRed;
                gr.DrawLines(myPen, buffer);
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            buffer = new Point[Width];
            for (int i = 0; i < Width; i++)
                buffer[i].X = i;
            cycle = 0;
        }
    }
}
