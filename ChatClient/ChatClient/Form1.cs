using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Newtonsoft.Json.Linq;
using ChatClient.Networking.Networking2;
using ChatClient.Networking.Networking2.Packets;



namespace ChatClient
{
    
    public partial class Form1 : Form
    {



        public static IPublisher<string> hello = new Publisher<string>();
        public Subscriber<string> msgSubscriber1;
        
        string message = "";
        ClientSocket sock = new ClientSocket();

        delegate void SetTextCallback(string text);
        
       
        
        
        
        
        
        
        
       
        
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void enterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                writeMessage(ref message);




            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //myInit();
            //mine.PacketReceived += new PacketReceiverHandler(UpdateUI);
            msgSubscriber1 = new Subscriber<string>(hello);
            msgSubscriber1.Publisher.DataPublisher += UpdateUI;
            this.txtMessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.enterPressed);
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.enterPressed);
            //sock.Connect("45.63.1.88", 1060);
            sock.Connect("127.0.0.1", 8888);
            
            
            


        }

        private void UpdateUI(object sender, MessageArgument<string> e)
        {
            //Console.WriteLine("I made it all the way to this method " + e.Message + "\n if blank it's earlier in the chain. Otherwise check if ui can't be updated");
            SetText(e.Message + "\r\n"); 
            
        }
        private void writeMessage(ref string arg)
        {
            if (txtName.Text == "")
                arg += "Anon: " + txtMessage.Text + "\r\n";
            else
                arg += txtName.Text + ": " + txtMessage.Text + "\r\n";
            txtChatBox.Text += arg;
            txtMessage.Clear();
            string local = arg.Trim();
            MyMessage message = new MyMessage(local);
            sock.Send(message.Data);
            
            
            
            arg = "";
            local = "";
            
        }
        public void myInit()
        {
            //mine = new PacketReceiver();
            //PacketHandler.me.PacketReceived += new PacketReceiverHandler(UpdateUI);
            //mine.PacketReceived
            
            //mine.PacketReceived += test;
            
            



        }
        private void SetText(string text)
		{
			// InvokeRequired required compares the thread ID of the
			// calling thread to the thread ID of the creating thread.
			// If these threads are different, it returns true.
			
            if (this.txtChatBox.InvokeRequired)
            {
                SetTextCallback c = new SetTextCallback(SetText);
                this.Invoke(c, new Object[] { text });

            }
            else 
            {
                this.txtChatBox.Text += text;
            }
		}









    }
}




