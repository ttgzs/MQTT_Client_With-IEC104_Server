/*
 * Created by SharpDevelop.
 * User: uau556
 * Date: 4-12-2017
 * Time: 9:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MQTT_Client
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox MessageTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button PublishButton;
		private System.Windows.Forms.Button ConnectButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.TextBox PubMessageTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button DisconnectButton;
		private System.Windows.Forms.TextBox PortTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button SubscribeButton;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox PubTopicTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button UnsubscribeButton;
		private System.Windows.Forms.ComboBox QosComboBox;
		private System.Windows.Forms.ListBox SubListBox;
		private System.Windows.Forms.CheckBox RetainCheckBox;
		private System.Windows.Forms.TextBox SubTopicTextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ComboBox HostComboBox;
		private System.Windows.Forms.ComboBox UserComboBox;
		private System.Windows.Forms.ComboBox SubScrComboBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox iec104Box;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.MessageTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.PublishButton = new System.Windows.Forms.Button();
			this.ConnectButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.PubMessageTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.DisconnectButton = new System.Windows.Forms.Button();
			this.PortTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SubscribeButton = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.PubTopicTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.UnsubscribeButton = new System.Windows.Forms.Button();
			this.QosComboBox = new System.Windows.Forms.ComboBox();
			this.SubListBox = new System.Windows.Forms.ListBox();
			this.RetainCheckBox = new System.Windows.Forms.CheckBox();
			this.SubTopicTextBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.HostComboBox = new System.Windows.Forms.ComboBox();
			this.UserComboBox = new System.Windows.Forms.ComboBox();
			this.SubScrComboBox = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.iec104Box = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// MessageTextBox
			// 
			this.MessageTextBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MessageTextBox.Location = new System.Drawing.Point(10, 363);
			this.MessageTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MessageTextBox.Multiline = true;
			this.MessageTextBox.Name = "MessageTextBox";
			this.MessageTextBox.ReadOnly = true;
			this.MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.MessageTextBox.Size = new System.Drawing.Size(958, 162);
			this.MessageTextBox.TabIndex = 11;
			this.MessageTextBox.TextChanged += new System.EventHandler(this.MessageTextBoxTextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(10, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Host:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 180);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Topic for sub:";
			// 
			// PublishButton
			// 
			this.PublishButton.Enabled = false;
			this.PublishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PublishButton.Location = new System.Drawing.Point(10, 324);
			this.PublishButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.PublishButton.Name = "PublishButton";
			this.PublishButton.Size = new System.Drawing.Size(561, 31);
			this.PublishButton.TabIndex = 9;
			this.PublishButton.Text = "Publish";
			this.PublishButton.UseVisualStyleBackColor = true;
			this.PublishButton.Click += new System.EventHandler(this.PublishButtonClick);
			// 
			// ConnectButton
			// 
			this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConnectButton.Location = new System.Drawing.Point(461, 8);
			this.ConnectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ConnectButton.Name = "ConnectButton";
			this.ConnectButton.Size = new System.Drawing.Size(110, 31);
			this.ConnectButton.TabIndex = 4;
			this.ConnectButton.Text = "Connect";
			this.ConnectButton.UseVisualStyleBackColor = true;
			this.ConnectButton.Click += new System.EventHandler(this.ConnectButtonClick);
			// 
			// ClearButton
			// 
			this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClearButton.Location = new System.Drawing.Point(10, 533);
			this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(958, 31);
			this.ClearButton.TabIndex = 10;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// PubMessageTextBox
			// 
			this.PubMessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PubMessageTextBox.Location = new System.Drawing.Point(123, 290);
			this.PubMessageTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.PubMessageTextBox.MaxLength = 128;
			this.PubMessageTextBox.Name = "PubMessageTextBox";
			this.PubMessageTextBox.Size = new System.Drawing.Size(448, 27);
			this.PubMessageTextBox.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(10, 290);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Message:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(14, 668);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 24);
			this.label4.TabIndex = 10;
			// 
			// DisconnectButton
			// 
			this.DisconnectButton.Enabled = false;
			this.DisconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DisconnectButton.Location = new System.Drawing.Point(461, 48);
			this.DisconnectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.DisconnectButton.Name = "DisconnectButton";
			this.DisconnectButton.Size = new System.Drawing.Size(110, 31);
			this.DisconnectButton.TabIndex = 12;
			this.DisconnectButton.Text = "Disconnect";
			this.DisconnectButton.UseVisualStyleBackColor = true;
			this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButtonClick);
			// 
			// PortTextBox
			// 
			this.PortTextBox.Location = new System.Drawing.Point(66, 54);
			this.PortTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.PortTextBox.MaxLength = 4;
			this.PortTextBox.Name = "PortTextBox";
			this.PortTextBox.Size = new System.Drawing.Size(52, 27);
			this.PortTextBox.TabIndex = 3;
			this.PortTextBox.Text = "1883";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(10, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 20);
			this.label5.TabIndex = 13;
			this.label5.Text = "Port:";
			// 
			// SubscribeButton
			// 
			this.SubscribeButton.Enabled = false;
			this.SubscribeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubscribeButton.Location = new System.Drawing.Point(461, 180);
			this.SubscribeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SubscribeButton.Name = "SubscribeButton";
			this.SubscribeButton.Size = new System.Drawing.Size(111, 31);
			this.SubscribeButton.TabIndex = 7;
			this.SubscribeButton.Text = "Subscribe";
			this.SubscribeButton.UseVisualStyleBackColor = true;
			this.SubscribeButton.Click += new System.EventHandler(this.SubscribeButtonClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(10, 252);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 20);
			this.label6.TabIndex = 14;
			this.label6.Text = "Topic for pub:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(132, 53);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 20);
			this.label7.TabIndex = 16;
			this.label7.Text = "QoS:";
			// 
			// PubTopicTextBox
			// 
			this.PubTopicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PubTopicTextBox.Location = new System.Drawing.Point(123, 252);
			this.PubTopicTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.PubTopicTextBox.MaxLength = 128;
			this.PubTopicTextBox.Name = "PubTopicTextBox";
			this.PubTopicTextBox.Size = new System.Drawing.Size(448, 27);
			this.PubTopicTextBox.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(582, 12);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(157, 20);
			this.label8.TabIndex = 19;
			this.label8.Text = "Subscriptions topic:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(311, 53);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(62, 20);
			this.label9.TabIndex = 21;
			this.label9.Text = "Retain:";
			// 
			// UnsubscribeButton
			// 
			this.UnsubscribeButton.Enabled = false;
			this.UnsubscribeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UnsubscribeButton.Location = new System.Drawing.Point(586, 324);
			this.UnsubscribeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.UnsubscribeButton.Name = "UnsubscribeButton";
			this.UnsubscribeButton.Size = new System.Drawing.Size(382, 31);
			this.UnsubscribeButton.TabIndex = 20;
			this.UnsubscribeButton.Text = "Unsubscribe";
			this.UnsubscribeButton.UseVisualStyleBackColor = true;
			this.UnsubscribeButton.Click += new System.EventHandler(this.UnsubscribeButtonClick);
			// 
			// QosComboBox
			// 
			this.QosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.QosComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.QosComboBox.FormattingEnabled = true;
			this.QosComboBox.Items.AddRange(new object[] {
			"0 At most once",
			"1 At least once",
			"2 Exactly once"});
			this.QosComboBox.Location = new System.Drawing.Point(185, 53);
			this.QosComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.QosComboBox.MaxDropDownItems = 3;
			this.QosComboBox.Name = "QosComboBox";
			this.QosComboBox.Size = new System.Drawing.Size(120, 28);
			this.QosComboBox.TabIndex = 17;
			this.QosComboBox.SelectedIndexChanged += new System.EventHandler(this.QosComboBoxSelectedIndexChanged);
			// 
			// SubListBox
			// 
			this.SubListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubListBox.FormattingEnabled = true;
			this.SubListBox.HorizontalScrollbar = true;
			this.SubListBox.ItemHeight = 20;
			this.SubListBox.Location = new System.Drawing.Point(586, 40);
			this.SubListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SubListBox.Name = "SubListBox";
			this.SubListBox.ScrollAlwaysVisible = true;
			this.SubListBox.Size = new System.Drawing.Size(382, 264);
			this.SubListBox.TabIndex = 18;
			// 
			// RetainCheckBox
			// 
			this.RetainCheckBox.AutoSize = true;
			this.RetainCheckBox.Location = new System.Drawing.Point(379, 59);
			this.RetainCheckBox.Name = "RetainCheckBox";
			this.RetainCheckBox.Size = new System.Drawing.Size(18, 17);
			this.RetainCheckBox.TabIndex = 22;
			this.RetainCheckBox.UseVisualStyleBackColor = true;
			// 
			// SubTopicTextBox
			// 
			this.SubTopicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTopicTextBox.Location = new System.Drawing.Point(123, 180);
			this.SubTopicTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SubTopicTextBox.MaxLength = 128;
			this.SubTopicTextBox.Name = "SubTopicTextBox";
			this.SubTopicTextBox.Size = new System.Drawing.Size(332, 27);
			this.SubTopicTextBox.TabIndex = 6;
			this.SubTopicTextBox.Text = "device/pwF2wCzcA5Ni9CAPFzYktftt/asset/#/feed";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(10, 110);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 24;
			this.label10.Text = "Username :";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(10, 144);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 26;
			this.label11.Text = "Password :";
			this.label11.Click += new System.EventHandler(this.Label11Click);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(116, 140);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(449, 27);
			this.textBox2.TabIndex = 27;
			this.textBox2.Text = "rick2000";
			// 
			// HostComboBox
			// 
			this.HostComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.HostComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HostComboBox.FormattingEnabled = true;
			this.HostComboBox.Items.AddRange(new object[] {
			"api.allthingstalk.io",
			"10.10.10.6"});
			this.HostComboBox.Location = new System.Drawing.Point(77, 10);
			this.HostComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.HostComboBox.MaxDropDownItems = 3;
			this.HostComboBox.Name = "HostComboBox";
			this.HostComboBox.Size = new System.Drawing.Size(331, 28);
			this.HostComboBox.TabIndex = 28;
			this.HostComboBox.SelectedIndexChanged += new System.EventHandler(this.HostComboBoxSelectedIndexChanged);
			// 
			// UserComboBox
			// 
			this.UserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.UserComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UserComboBox.FormattingEnabled = true;
			this.UserComboBox.Items.AddRange(new object[] {
			"maker:4KbVgav9eGaHW1VeVyHJUWA5Bk9eyeVo7c6efz60",
			"rick"});
			this.UserComboBox.Location = new System.Drawing.Point(116, 105);
			this.UserComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.UserComboBox.MaxDropDownItems = 3;
			this.UserComboBox.Name = "UserComboBox";
			this.UserComboBox.Size = new System.Drawing.Size(449, 28);
			this.UserComboBox.TabIndex = 29;
			this.UserComboBox.SelectedIndexChanged += new System.EventHandler(this.UserComboBoxSelectedIndexChanged);
			// 
			// SubScrComboBox
			// 
			this.SubScrComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SubScrComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubScrComboBox.FormattingEnabled = true;
			this.SubScrComboBox.Items.AddRange(new object[] {
			"device/pwF2wCzcA5Ni9CAPFzYktftt/asset/#/feed",
			"trap/#"});
			this.SubScrComboBox.Location = new System.Drawing.Point(122, 214);
			this.SubScrComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SubScrComboBox.MaxDropDownItems = 3;
			this.SubScrComboBox.Name = "SubScrComboBox";
			this.SubScrComboBox.Size = new System.Drawing.Size(450, 28);
			this.SubScrComboBox.TabIndex = 30;
			this.SubScrComboBox.SelectedIndexChanged += new System.EventHandler(this.SubScrComboBoxSelectedIndexChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(12, 217);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(110, 20);
			this.label12.TabIndex = 31;
			this.label12.Text = "Example sub:";
			this.label12.Click += new System.EventHandler(this.Label12Click);
			// 
			// iec104Box
			// 
			this.iec104Box.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iec104Box.Location = new System.Drawing.Point(10, 600);
			this.iec104Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.iec104Box.Multiline = true;
			this.iec104Box.Name = "iec104Box";
			this.iec104Box.ReadOnly = true;
			this.iec104Box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.iec104Box.Size = new System.Drawing.Size(958, 202);
			this.iec104Box.TabIndex = 32;
			this.iec104Box.TextChanged += new System.EventHandler(this.Iec104BoxTextChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(14, 569);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(127, 24);
			this.checkBox1.TabIndex = 33;
			this.checkBox1.Text = "Start IEC104";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(10, 825);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(958, 28);
			this.button2.TabIndex = 34;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(876, 8);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(92, 23);
			this.button3.TabIndex = 36;
			this.button3.Text = "Sluit";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(990, 865);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.iec104Box);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.SubScrComboBox);
			this.Controls.Add(this.UserComboBox);
			this.Controls.Add(this.HostComboBox);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.SubTopicTextBox);
			this.Controls.Add(this.RetainCheckBox);
			this.Controls.Add(this.SubListBox);
			this.Controls.Add(this.QosComboBox);
			this.Controls.Add(this.UnsubscribeButton);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.PubTopicTextBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.SubscribeButton);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.PortTextBox);
			this.Controls.Add(this.DisconnectButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.PubMessageTextBox);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.ConnectButton);
			this.Controls.Add(this.PublishButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.MessageTextBox);
			this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.Text = "MQTT Client";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		}
}
