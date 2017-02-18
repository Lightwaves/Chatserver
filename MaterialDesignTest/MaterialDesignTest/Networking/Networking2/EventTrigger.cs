using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialDesignTest.Networking
{
    public class PacketReceiverEventArgs : EventArgs
    {
        private string data;

        public PacketReceiverEventArgs(string data)
        {
            this.data = data;

        }
        public string Data
        {
            get { return data; }
        }
    }
    public delegate void PacketReceiverHandler(object sender, PacketReceiverEventArgs e);

    public class PacketReceiver
    {
        private string mymsg;

        public string MyMSG 
        {
            get { return mymsg; }
            set 
            {
                this.mymsg = value;    
                OnPacketReceived(this, new PacketReceiverEventArgs(mymsg)); 
            }
        }

        

        public event PacketReceiverHandler PacketReceived;

        protected virtual void OnPacketReceived(object sender, PacketReceiverEventArgs e)
        {
            PacketReceiverHandler handler = PacketReceived;
            Console.WriteLine(e.Data + " if not blank handler may be null");
            
            if (handler != null)
            {
                // Invokes the delegates.
                Console.WriteLine("got data from PR_event_args " + e.Data + " passing to handler");
                handler(this, e);
            }
        }
        /*
        public void Start()
        {
            Console.WriteLine("start has msg " + msg + " passing to PR_event_args");
            PacketReceiverEventArgs e = new PacketReceiverEventArgs(msg);
            Console.WriteLine("data passed to event args is "+ e.Data);
            
            OnPacketReceived(this, e);
        }
        */
       
    }
}
