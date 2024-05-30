using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace convolucion
{
    
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort arduino;
        public Form1()
        {
            InitializeComponent();
            arduino = new System.IO.Ports.SerialPort();
            arduino.PortName = "COM5";
            arduino.BaudRate = 9600;
            arduino.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(arduino.IsOpen)
            {
                arduino.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\jonat\\Desktop\\bluetho\\maestro\\convolucion.txt");
           // Read the first line of text line =
            string line=sr.ReadLine();
            arduino.Write(line);
            sr.Close();
        }
    }
}
