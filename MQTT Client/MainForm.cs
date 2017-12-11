/*
 * Created by SharpDevelop.
 * User: uau556
 * Date: 4-12-2017
 * Time: 9:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using lib60870;
using System.Net.Sockets;
using System.Threading;



namespace MQTT_Client
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		bool running = true;
		Server server = new Server ();
		public ASDU newAsdu;
		public BitArray myBA;
		
		private delegate void myUICallBack(string myStr, TextBox ctl);
        static MqttClient client;
        private void myUI(string myStr, TextBox ctl)
        {
            if (this.InvokeRequired)
            {
                myUICallBack myUpdate = new myUICallBack(myUI);
                this.Invoke(myUpdate, myStr, ctl);
            }
            else
            {
                ctl.AppendText(myStr + Environment.NewLine);
            }
        }

        
        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            var type_sensor = System.Text.Encoding.UTF8.GetString(e.Message);
            type_sensor = type_sensor.Substring(44,10);
            
            switch(type_sensor){
            		case "bit_status":
            		    var json = System.Text.Encoding.UTF8.GetString(e.Message);
            			json = json.Substring(56,2).TrimEnd('}');
            			myUI(type_sensor + " : " + json, MessageTextBox);
 						int bit_stat = Int32.Parse(json);
   						SendIECStatus(Convert.ToByte(bit_stat));
						break;
            		case "temperatur":
						var temp = System.Text.Encoding.UTF8.GetString(e.Message);
						int temp_lengte = temp.Length - 58;
						temp = temp.Substring(56,temp_lengte).TrimEnd('}');
						int punt_temp = temp.IndexOf('.');
						temp = temp.Substring(0,punt_temp);
            			myUI(type_sensor + " : " + temp, MessageTextBox);
 						int temp_stat = Int32.Parse(temp);
   						SendIECTemp(Convert.ToByte(temp_stat));
            			break;		
            		case "humidities":
            			var humi = System.Text.Encoding.UTF8.GetString(e.Message);
            			int humi_lengte = humi.Length - 58;
						humi = humi.Substring(56,humi_lengte).TrimEnd('}');
						int punt_humi = humi.IndexOf('.');
						humi = humi.Substring(0,punt_humi);
            			myUI(type_sensor + " : " + humi, MessageTextBox);
 						int humi_stat = Int32.Parse(humi);
   						SendIECHumi(Convert.ToByte(humi_stat));
            			break;		
            }
        }
		
        public MainForm()
		{
			InitializeComponent();
		}
	
        
       
        //IEC104 procedures
        private static bool interrogationHandler(object parameter, ServerConnection connection, ASDU asdu,  byte qoi)
		{
        	
        	
        	//BitArray myBA = new BitArray(BitConverter.GetBytes(parameter).ToArray());
			//Console.WriteLine ("Interrogation for group " + qoi);
			
			if (qoi == 20) { /* Station interrogation */

				connection.SendACT_CON (asdu, false);

				ConnectionParameters cp = connection.GetConnectionParameters ();

				// The CS101 allows only information object without timestamps in GI responses!

				// send information objects
				ASDU newAsdu = new ASDU (cp, CauseOfTransmission.INTERROGATED_BY_STATION, false, false, 2, 1, false);

				newAsdu = new ASDU (cp, CauseOfTransmission.INTERROGATED_BY_STATION, false, false, 2, 1, true);
/*
				myUI("SEND: INTERROGATED_BY_STATION : SinglePointInformation  : IOA=200 : CA=1 VALUE=false",iec104Box);
				myUI("SEND: INTERROGATED_BY_STATION : SinglePointInformation  : IOA=201 : CA=1 VALUE=false",iec104Box);
				myUI("SEND: INTERROGATED_BY_STATION : SinglePointInformation  : IOA=202 : CA=1 VALUE=false",iec104Box);
				myUI("SEND: INTERROGATED_BY_STATION : SinglePointInformation  : IOA=203 : CA=1 VALUE=false",iec104Box);
				myUI("SEND: INTERROGATED_BY_STATION : SinglePointInformation  : IOA=204 : CA=1 VALUE=false",iec104Box);
				myUI("SEND: INTERROGATED_BY_STATION : SinglePointInformation  : IOA=205 : CA=1 VALUE=false",iec104Box);
*/
				newAsdu.AddInformationObject (new SinglePointInformation (200, false, new QualityDescriptor ()));
				newAsdu.AddInformationObject (new SinglePointInformation (201, false, new QualityDescriptor ()));
				newAsdu.AddInformationObject (new SinglePointInformation (202, false, new QualityDescriptor ()));
				newAsdu.AddInformationObject (new SinglePointInformation (203, false, new QualityDescriptor ()));
				newAsdu.AddInformationObject (new SinglePointInformation (204, false, new QualityDescriptor ()));
				newAsdu.AddInformationObject (new SinglePointInformation (205, false, new QualityDescriptor ()));
				
				connection.SendASDU (newAsdu);

				newAsdu = new ASDU (cp, CauseOfTransmission.INTERROGATED_BY_STATION, false, false, 2, 1, true);
/*				myUI("SEND: INTERROGATED_BY_STATION : MeasuredValueNormalized : IOA=302 : CA=1 VALUE=0",iec104Box);
				myUI("SEND: INTERROGATED_BY_STATION : MeasuredValueNormalized : IOA=302 : CA=1 VALUE=0",iec104Box);
*/			
				newAsdu.AddInformationObject (new MeasuredValueNormalized ( 301, 0,new QualityDescriptor ()));
				newAsdu.AddInformationObject (new MeasuredValueNormalized ( 302, 0,new QualityDescriptor ()));
				
				
				connection.SendASDU (newAsdu);

				connection.SendACT_TERM (asdu);
			} else {
				connection.SendACT_CON (asdu, true);
			}

			return true;
		}

        
        
        
        
        private static bool asduHandler(object parameter, ServerConnection connection, ASDU asdu)
		{
			
			if (asdu.TypeId == TypeID.C_SC_NA_1) {
				Console.WriteLine ("Single command");

				SingleCommand sc = (SingleCommand)asdu.GetElement (0);

				Console.WriteLine (sc.ToString ());
			} 
			else if (asdu.TypeId == TypeID.C_CS_NA_1){
				

				ClockSynchronizationCommand qsc = (ClockSynchronizationCommand)asdu.GetElement (0);

				Console.WriteLine ("Received clock sync command with time " + qsc.NewTime.ToString());
			}

			return true;
		}
        
	
		private void MainForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.ConnectButton;
            QosComboBox.SelectedIndex = 0;
            UserComboBox.SelectedIndex = 0;
            HostComboBox.SelectedIndex = 0;
            SubScrComboBox.SelectedIndex = 0;
            checkBox1.Checked = true;
            
            //IEC104 setting
			server.DebugOutput = true;
			server.MaxQueueSize = 10;
			server.SetInterrogationHandler (interrogationHandler,  null);
			server.SetASDUHandler (asduHandler, null);
			server.SetLocalPort(2404);
			//server.SetLocalAddress("10.10.10.7");
			server.Start ();
			
            
        }
		private void SendIECStatus(byte status_bit){
			myBA = new BitArray(BitConverter.GetBytes(status_bit).ToArray());
			myUI("SEND: SPONTANEOUS : SinglePointInformation  : IOA=200 : CA=1 VALUE=" + myBA[0].ToString(),iec104Box);
			myUI("SEND: SPONTANEOUS : SinglePointInformation  : IOA=201 : CA=1 VALUE=" + myBA[1].ToString(),iec104Box);
			myUI("SEND: SPONTANEOUS : SinglePointInformation  : IOA=202 : CA=1 VALUE=" + myBA[2].ToString(),iec104Box);
			myUI("SEND: SPONTANEOUS : SinglePointInformation  : IOA=203 : CA=1 VALUE=" + myBA[3].ToString(),iec104Box);
			myUI("SEND: SPONTANEOUS : SinglePointInformation  : IOA=204 : CA=1 VALUE=" + myBA[4].ToString(),iec104Box);
			myUI("SEND: SPONTANEOUS : SinglePointInformation  : IOA=205 : CA=1 VALUE=" + myBA[5].ToString(),iec104Box);
			
			newAsdu = new ASDU (server.GetConnectionParameters(), CauseOfTransmission.SPONTANEOUS,  false , false, 2, 1, false);
		    newAsdu.AddInformationObject (new SinglePointInformation (200, myBA[0], new QualityDescriptor ()));				
			newAsdu.AddInformationObject (new SinglePointInformation (201, myBA[1], new QualityDescriptor ()));				
			newAsdu.AddInformationObject (new SinglePointInformation (202, myBA[2], new QualityDescriptor ()));				
			newAsdu.AddInformationObject (new SinglePointInformation (203, myBA[3], new QualityDescriptor ()));				
			newAsdu.AddInformationObject (new SinglePointInformation (204, myBA[4], new QualityDescriptor ()));				
			newAsdu.AddInformationObject (new SinglePointInformation (205, myBA[5], new QualityDescriptor ()));				
			server.EnqueueASDU (newAsdu);
			
		}

		private void SendIECTemp(byte temp_stat){
			
			myUI("SEND: SPONTANEOUS : MeasuredValueNormalized : IOA=301 : CA=1 VALUE=" + temp_stat.ToString(),iec104Box);
			
			newAsdu = new ASDU (server.GetConnectionParameters(), CauseOfTransmission.SPONTANEOUS,   false , false, 2, 1, false);
			newAsdu.AddInformationObject (new MeasuredValueNormalized ( 301,temp_stat,new QualityDescriptor ()));
			server.EnqueueASDU (newAsdu);
			
		}

		private void SendIECHumi(byte humi_stat){
			
			myUI("SEND: SPONTANEOUS : MeasuredValueNormalized : IOA=302 : CA=1 VALUE=" + humi_stat.ToString(),iec104Box);
			
			newAsdu = new ASDU (server.GetConnectionParameters(), CauseOfTransmission.SPONTANEOUS,  false , false, 2, 1, false);
		    newAsdu.AddInformationObject (new MeasuredValueNormalized ( 302, humi_stat,new QualityDescriptor ()));		
			server.EnqueueASDU (newAsdu);
			
		}


		
        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (client != null && client.IsConnected) client.Disconnect();
        }

		
		void PublishButtonClick(object sender, EventArgs e)
		{
	        if (PubMessageTextBox.Text.Length == 0)
            {
                label4.Text = "No message to send";
            }
            else if (PubTopicTextBox.Text.Length == 0)
            {
                label4.Text = "Publish topic can't be empty";
            }
            else if (PubTopicTextBox.Text.IndexOf('#') != -1 || PubTopicTextBox.Text.IndexOf('+') != -1)
            {
                label4.Text = "Publish topic can't include wildcard(# , +)";
            }
            else
            {
                label4.Text = "";
                client.Publish(PubTopicTextBox.Text, Encoding.UTF8.GetBytes(PubMessageTextBox.Text), (byte)QosComboBox.SelectedIndex, RetainCheckBox.Checked);
            }

		}
		void ConnectButtonClick(object sender, EventArgs e)
		{
	        int port;
            //if(HostTextBoxold.Text.Length == 0)
            if(HostComboBox.Text.Length  == 0)
            {
                label4.Text = "Invalid host";
            }
            else if (!Int32.TryParse(PortTextBox.Text, out port))
            {
                label4.Text = "Invalid port";
            }
            else
            {                
                try
                {
                	client = new MqttClient(HostComboBox.Text);
                	//client = new MqttClient(HostTextBoxold.Text);
                    client.ProtocolVersion = MqttProtocolVersion.Version_3_1;
                    
                    //client.Connect(Guid.NewGuid().ToString());
                    //client.Connect(Guid.NewGuid().ToString().Substring(0, 22),textBox1.Text,textBox2.Text,true,120);
                    client.Connect(Guid.NewGuid().ToString().Substring(0, 22),UserComboBox.Text,textBox2.Text,true,120);
                    
                    client.MqttMsgPublishReceived += new MqttClient.MqttMsgPublishEventHandler(client_MqttMsgPublishReceived);
                }
                catch
                {
                    label4.Text = "Can't connect to server";
                }
                if (client != null && client.IsConnected)
                {
                    this.AcceptButton = this.PublishButton;
                    label4.Text = "";
                    MessageTextBox.Clear();
                    SubscribeButton.Enabled = true;
                    PublishButton.Enabled = true;
                    UnsubscribeButton.Enabled = true;
                    DisconnectButton.Enabled = true;
                    ConnectButton.Enabled = false;
                    //HostTextBoxold.Enabled = false;
                    UserComboBox.Enabled = false;
                    PortTextBox.Enabled = false;
                    
                }else{
                	label4.Text = "Connected to server is false";
                }
            }

		}
		void ClearButtonClick(object sender, EventArgs e)
		{
	        MessageTextBox.Clear();
		}
		void DisconnectButtonClick(object sender, EventArgs e)
		{
	        if (client != null && client.IsConnected) client.Disconnect();
            SubscribeButton.Enabled = false;
            PublishButton.Enabled = false;
            UnsubscribeButton.Enabled = false;
            DisconnectButton.Enabled = false;
            ConnectButton.Enabled = true;            
            //HostTextBoxold.Enabled = true;
            UserComboBox.Enabled = true;
            PortTextBox.Enabled = true;
            SubListBox.Items.Clear();

		}
		void SubscribeButtonClick(object sender, EventArgs e)
		{
	        if (SubTopicTextBox.Text.Length == 0)
            {
                label4.Text = "Subscribe topic can't be empty";
            }
            else
            {
                label4.Text = "";
                client.Subscribe(new string[] { SubTopicTextBox.Text }, new byte[] { (byte)QosComboBox.SelectedIndex });
                SubListBox.Items.Add(SubTopicTextBox.Text);
            }

		}
		void UnsubscribeButtonClick(object sender, EventArgs e)
		{
	        if (SubListBox.SelectedItem == null)
            {
                label4.Text = "Select topic to unscribe";
            }
            else
            {
                label4.Text = "";
                client.Unsubscribe(new string[] { SubListBox.SelectedItem.ToString() });
                SubListBox.Items.Remove(SubListBox.SelectedItem);
            }

		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Label11Click(object sender, EventArgs e)
		{
	
		}
		void HostComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void UserComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void SubScrComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			SubTopicTextBox.Text = SubScrComboBox.SelectedItem.ToString() ;
		}
		void QosComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void Label12Click(object sender, EventArgs e)
		{
	
		}
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if(checkBox1.Checked){
				running = true;
				myUI("Start Server",iec104Box);
			}else{
				running = false;
				myUI("Stop Server",iec104Box);
			}
		}
		void MessageTextBoxTextChanged(object sender, EventArgs e)
		{
	
		}
		void Iec104BoxTextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			iec104Box.Clear();
		}
		void Button3Click(object sender, EventArgs e)
		{
			server.Stop();
			System.Windows.Forms.Application.Exit();
		}
	}
}
