using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Linq.Expressions;

namespace LightApp
{
    public partial class Form1 : Form
    {
        private SerialPort myport;
        private DateTime datetime;
        private string in_data;
        private string in_data2;
        string  serialDataIn; //
        sbyte indexOfA, indexOfB;
        int currentTD;



        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = port_name_tb.Text;
            myport.Parity = Parity.None;
            myport.DataBits = 8;
            myport.StopBits = StopBits.One;
            myport.DataReceived += myport_DataReceived;

            try{
                myport.Open();
                data_db.Text = "";
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }


           


          

        }

        private void myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {



             serialDataIn = myport.ReadLine();

            this.Invoke(new EventHandler(displaydata_event));

            

            


        }

        private void displaydata_event(object sender, EventArgs e)
        {

             indexOfA = Convert.ToSByte(serialDataIn.IndexOf('A'));
            //indexOfB = Convert.ToSByte(serialDataIn.IndexOf('B'));
            in_data2 = serialDataIn.Substring(0, indexOfA);
            // in_data = serialDataIn.Substring(indexOfA + 1, (indexOfB - indexOfA) - 1);

            //string[] sensorValues = serialDataIn.Split(',');


            //in_data = serialDataIn[0];


            //in_data2 = sensorValues[0];

           

            

                //datetime = DateTime.Now;
                //string time = datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second;
                //data_db.AppendText(time + "\t\t\t" + in_data + "\n");
            
                
          

               
                

           


            //int data_value = Convert.ToInt32(in_data);
            //value_pb.Value = data_value;


             textBox_Sound.Text = in_data2;

             //verticalProgressBar_sound.Value = Convert.ToInt16(in_data2);





        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            try
            {
                myport.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Error");
            }
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string pathFile = @"C:\\Users\\My PC\\Desktop\\DATA\\";
                string filename = "light_data.txt";
                System.IO.File.WriteAllText(pathFile + filename, data_db.Text);
                MessageBox.Show("Data has been saved to " + pathFile, "Save File");
            }
            catch(Exception ex3)
            {
                MessageBox.Show(ex3.Message, "Error");

            }





        }
    }
}
