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

namespace SmartLock_GUI
{
    public partial class Form1 : Form
    {
        SerialPort port;
        string data_rx="" , state ;
        bool flag = true ;
        public Form1()
        {
            InitializeComponent();
            Refresh_COM();
            State.Text = "Disconnected";
            State.BackColor = Color.Red;
            Screen.Enabled = false; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = data_rx ;
            if(data_rx == "O")
            {
                state = "ON";
                Screen.Enabled = true;
                LockState.Text = "ON";
                LockState.BackColor = Color.Green;
                
            }
            else if ( data_rx == "F")
            {    
                state = "OFF";
                Screen.Enabled = false;
                LockState.Text = "OFF";
                LockState.BackColor = Color.Red;
            }
            if(state == "ON" )
            {
               
                if (data_rx == "R" )
                {
                    if (flag == false)
                    {
                        flag = true;
                        MessageBox.Show("Password Accepted", "Entrance Succeeded");
                        textBox2.Text = "ok";
                      
                    }

                }
                else if (data_rx == "W" )
                {
                    if (flag == false)
                    {
                        flag = true;
                        MessageBox.Show("Wrong Password, Try again", "Entrance Failed");
                        textBox2.Text = "no";
                       
                    }
                }

            }
            if( flag == true)
            {
                SendPass();
            }
          
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (CheckPass_Length() && Screen.Enabled  )
                Screen.Text += "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (CheckPass_Length() && Screen.Enabled )
                Screen.Text += "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {

            if (CheckPass_Length() && Screen.Enabled )
                Screen.Text += "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (CheckPass_Length() && Screen.Enabled )
                Screen.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {

            if (CheckPass_Length() && Screen.Enabled)
                Screen.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {

            if (CheckPass_Length() && Screen.Enabled)
                Screen.Text += "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {

            if (CheckPass_Length() && Screen.Enabled)
                Screen.Text += "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {

            if (CheckPass_Length() && Screen.Enabled)
                Screen.Text += "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {   
         
           if(CheckPass_Length() && Screen.Enabled)  
            Screen.Text += "9";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClearScreen();
            // MessageBox.Show(Screen.Text.Length.ToString());
            // textBox2.Text = Screen.MaxLength.ToString();
          
        }
        private bool CheckPass_Length()
        {
            if (Screen.TextLength < Screen.MaxLength)
            {
                return true;
            }
            else return false; 
        }
        private void SendPass()
        {
            if (Screen.TextLength == Screen.MaxLength)
            {
                port.Write("@" + Screen.Text + ";");
                ClearScreen();
                flag = false;
                // MessageBox.Show(Screen.Text); 
            }
        }
        private void ClearScreen()
        {
            Screen.Text = "";
        }
        private void data_rx_handler(object sender, SerialDataReceivedEventArgs e) {
            SerialPort sp = (SerialPort)sender;
            string indata = "";
            try
            {
                indata = sp.ReadExisting();
            }


            catch (Exception ex) { }
            data_rx = indata; 
        }
       
        private void Refresh_COM()
        {
            Ports.DataSource = SerialPort.GetPortNames();
        }
        private void Connect_COM()
        {
            port = new SerialPort(Ports.SelectedItem.ToString());
            port.DataReceived += new SerialDataReceivedEventHandler(data_rx_handler);
            port.BaudRate = 9600;
            port.DataBits = 8;
            port.StopBits = StopBits.One;
            try
            {
                if (!port.IsOpen)
                {
                    port.Open();
                    State.Text = "Connected";
                    State.BackColor = Color.Green;
                }
            }
            catch (Exception e)
            { }

        }
        private void Disconnect_COM()
        {
            try
            {
                if (port.IsOpen)
                {
                    port.Close();
                    State.Text = "Disconnected";
                    State.BackColor = Color.Red;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You are not connected to any port");

            }
            catch (Exception e)
            {

            }

        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            Refresh_COM();
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            Connect_COM();
        }

        private void Disconnect_Button_Click(object sender, EventArgs e)
        {
            Disconnect_COM();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           Disconnect_COM();
        }
    }
}
