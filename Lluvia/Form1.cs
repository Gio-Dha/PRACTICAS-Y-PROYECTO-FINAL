using System;
using System.IO.Ports;
using System.Media;
using System.Windows.Forms;

namespace Lluvia
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private bool isBlinking;
        private SoundPlayer soundPlayer;
        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM8", 9600);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            botonComenzar.Click += botonComenzar_Click;
            timer1.Interval = 500; // Intervalo de parpadeo en milisegundos
            timer1.Tick += timer1_Tick;
            soundPlayer = new SoundPlayer("D:\\Emergency Siren Police Wail 02.wav");

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }

        }
        /*private void Timer1_Tick(object? sender,EventArgs e)
         * {throw new NotImplementedException();
         }*/
        private void botonComenzar_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.Open();

            }
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            this.Invoke(new Action(() =>
            {
                label1.Text = "Snesor Status:" + (data.Trim() == "1" ? "Water detected" : "No water detected");
                if (data.Trim() == "1")
                {
                    if (!isBlinking)
                    {
                        timer1.Start();
                        soundPlayer.PlayLooping();
                        pictureBox1.BackColor = System.Drawing.Color.Red;
                        isBlinking = true;
                    }
                }
                else
                {
                    if (isBlinking)
                    {
                        timer1.Stop();
                        soundPlayer.Stop();
                        pictureBox1.BackColor = System.Drawing.Color.Gray;
                        isBlinking = false;
                    }
                }
            }));

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.BackColor = pictureBox1.BackColor == System.Drawing.Color.Gray ? System.Drawing.Color.Yellow : System.Drawing.Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            Application.Exit();
        }
    }
}
