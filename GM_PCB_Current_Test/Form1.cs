using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments.VisaNS;

namespace GM_PCB_Current_Test
{
    public partial class Form1 : Form
    {

        public static string sAddress="";


        public Form1()
        {
            InitializeComponent();
        }

        

        private static void InitializeProject()
        {
            sAddress = "GPIB0::10::INSTR";


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPowerSupplyAddress.Text = "GPIB0::10::INSTR";
            InitializeProject();
            
        }

        private void btnCreateConnection_Click(object sender, EventArgs e)
        {
            try
            {
                sAddress = txtPowerSupplyAddress.Text;
                //The VNA uses a message based session
                MessageBasedSession mbSession = null;
                //But we'll just open a generic Session first
                Session mySession = null;

                //response string
                string responseString = null;
                //open a Session to the VNA
                mySession = ResourceManager.GetLocalManager().Open(sAddress);
                //cast this to a message based session
                mbSession = (MessageBasedSession)mySession;

                if(mbSession==null)
                {
                    MessageBox.Show("Bağlantı kurulamadı");
                }
                
                //Send "*IDN?" command
                mbSession.Write("*IDN?\n");
                //Notice that the Session Write commands are terminated with a “/n”.
                //This is the newline character and is not really needed for GPIB,
                //USB or VXI-11, but is needed for Sockets.
                //It doesn’t cause any problems to include it.
                //Read the response
                responseString = mbSession.ReadString();

                //Write to Console
                Console.WriteLine("Response to *IDN?:");

                MessageBox.Show("Bağlantı başarılı bir şekilde kuruldu"+"\nBağlantı kurulan cihaz\n"+responseString);
                Console.WriteLine(responseString);
                //Return to Local Control
                mbSession.Write("RTL\n");
                //Close the Session
                mbSession.Dispose();

            }
            catch (VisaException v_exp)
            {
                Console.WriteLine("Visa caught an error!!");
                Console.WriteLine(v_exp.Message);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Something didn't work!!");
                Console.WriteLine(exp.Message);
                Console.WriteLine();
            }
        }

        private void btnRunCommand_Click(object sender, EventArgs e)
        {
            if(txtCommandLine.Text==String.Empty)
            {
                MessageBox.Show("Komut boş olamaz");
            }
            else
            {
                try
                {

                    rtxtEquipmentResponse.Clear();


                    //The VNA uses a message based session
                    MessageBasedSession mbSession = null;
                    //But we'll just open a generic Session first
                    Session mySession = null;

                    //response string
                    string responseString = null;
                    //open a Session to the VNA
                    mySession = ResourceManager.GetLocalManager().Open(sAddress);
                    //cast this to a message based session
                    mbSession = (MessageBasedSession)mySession;

                    if (mbSession == null)
                    {
                        MessageBox.Show("Bağlantı kurulamadı");
                    }
                    rtxtEquipmentResponse.Text = "Komut gönderme başarılı\n";
                    //Send "*IDN?" command
                    mbSession.Write(txtCommandLine.Text + "\n");
                    //Notice that the Session Write commands are terminated with a “/n”.
                    //This is the newline character and is not really needed for GPIB,
                    //USB or VXI-11, but is needed for Sockets.
                    //It doesn’t cause any problems to include it.
                    //Read the response
                    responseString = mbSession.ReadString();
                    rtxtEquipmentResponse.AppendText("\nGönderilen komut : " + txtCommandLine.Text);
                    rtxtEquipmentResponse.AppendText("\n\nEkipmandan alınan cevap :\n");
                    rtxtEquipmentResponse.AppendText("\n" + responseString);
                    //Return to Local Control
                    //mbSession.Write("*RTL?\n");
                    //Close the Session
                    mbSession.Dispose();

                }
                catch (VisaException v_exp)
                {
                    Console.WriteLine("Visa caught an error!!");
                    Console.WriteLine(v_exp.Message);
                }
                catch (Exception exp)
                {
                    Console.WriteLine("Something didn't work!!");
                    Console.WriteLine(exp.Message);
                    Console.WriteLine();
                }
            }

            
        }
    }

    
}
