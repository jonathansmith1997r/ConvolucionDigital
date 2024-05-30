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
using System.Threading;
using System.IO.Ports;

namespace deconvolucion
{
    public partial class Form1 : Form
    {
        //string datos_puerto;
        //private Thread readThread = null;
        private SerialPort port = new SerialPort("COM3",
                    9600, Parity.None, 8, StopBits.One);
        

        // System.IO.Ports.SerialPort puerto;
        public Form1()
        {
            InitializeComponent();

            read();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (port.IsOpen)
            {
                port.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {/*
            puerto = new System.IO.Ports.SerialPort();
            puerto.PortName = "COM3";
            puerto.BaudRate = 9600;
            puerto.DtrEnable = false;
            puerto.ReadTimeout = 50000;
            puerto.Open();
           */
            //port.ReadTimeout = 50000;
            

        }
        public void read()
        {

            /*
            while (puerto.IsOpen)
            {
                try
                {
                    string message = puerto.ReadLine();
                    MessageBox.Show(message);
                }
                catch (TimeoutException) {
                    MessageBox.Show("no llego");
                }
            }
            */
            port.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            port.Open();
            Console.ReadLine();
        }
        
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            /*
            MessageBox.Show("esta recibiendo");
            datos_puerto = this.puerto.ReadLine();
            if (datos_puerto.StartsWith("$"))
            {
                MessageBox.Show("encontro");
                this.Invoke(new EventHandler(actualizar));
            }
            */
            //System.IO.Ports.SerialPort spl = (System.IO.Ports.SerialPort)sender;
            //const int buffSize = 12;
            //Byte[] buf = new Byte[buffSize];
            //MessageBox.Show(spl.Read(buf, 0, buffSize));

           // char[] arr = port.ReadExisting().ToCharArray();
           // Console.WriteLine(port.ReadExisting());
            StreamWriter writetext = new StreamWriter("C:" +
            "\\Users\\jonat\\Desktop\\bluetho\\esclavo\\deconvolucion.txt");
            writetext.WriteLine(port.ReadExisting());
            writetext.Close();
            //File.WriteAllText("C:\\Users\\jonat\\Desktop\\bluetho\\esclavo\\deconvolucion.txt", port.ReadExisting());
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*StreamWriter writetext = new StreamWriter("C:\Users\jonat\Desktop\bluetho\esclavo\deconvolucion\\convolucion.txt");
           writetext.WriteLine(line);
           writetext.Close();*/
            //MessageBox.Show(line);
            read();
        }
        /*
        public void serial()
        {
            try
            {
                this.puerto = new System.IO.Ports.SerialPort("COM3",9600,System.IO.Ports.Parity.None,8,System.IO.Ports.StopBits.One);
                this.puerto.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(serialPort1_DataReceived) ;
            }
            catch(Exception e)
            {

            }
           
        }
        public void actualizar(object s, EventArgs e)
        {
            MessageBox.Show(datos_puerto);
        }
        */
    }
}
