using System.IO.Packaging;
using System;
using System.IO.Ports;
using System.Windows.Forms;
    
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Arduino;
        //SerialPort serialPort;





        public Form1()
        {

            InitializeComponent();
            Arduino = new System.IO.Ports.SerialPort();
            Arduino = new SerialPort("COM7", 9600);

            Arduino.Open();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arduino.Write("E");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Arduino.IsOpen)
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arduino.Write("F");
        }
    }
}
