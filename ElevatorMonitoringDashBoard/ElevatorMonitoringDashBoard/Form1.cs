using System;
using System.Windows.Forms;
using System.IO.Ports;


namespace ElevatorMonitoringDashBoard
{
    public partial class Form1 : Form
    {

        private SerialPort myport;
        private DateTime datetime;
        private string in_data;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
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


            myport.DataReceived += myport_DataReceived; //need to know


            try
            {
                myport.Open();
                data_tb.Text = "";
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }


        }

        private void myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            in_data = myport.ReadLine();


            this.Invoke(new EventHandler(displaydata_event));
            this.Invoke(new EventHandler(displaydata_event));

           
           
        }

        private void displaydata_event(object sender, EventArgs e)
        {

            datetime = DateTime.Now;

              string time ="Date: "+datetime.Year+":"+datetime.Month+ ":"+ datetime.Day + " Time: " +datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second;
             data_tb.AppendText( time + "\t\t" + in_data + "\n");




            textBox_sound.Text = in_data;
            verticalProgressbar_sound.Value = Convert.ToInt16(in_data);

        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            try
            {
                myport.Close();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string pathFile = @"C:\\Users\\My PC\\Desktop\\Sample DataBase\\";
                string filename = "Distance_Travelled.txt";

                System.IO.File.WriteAllText(pathFile + filename, data_tb.Text);
                MessageBox.Show("Data has been saved to " + pathFile, "Save File");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }


        }
    }
}
