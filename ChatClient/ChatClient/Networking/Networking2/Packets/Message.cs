using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.Networking.Networking2.Packets
{
    class MyMessage : PacketStructure
    {
        private string _message;
        
        public MyMessage(string message)
            : base((ushort)(message.Length), 1)
        {
            Text = message;
        }
        public MyMessage(byte[] packet)
            :base(packet)
        {

        }
        public string Text
        {
            get { return ReadString(4, Data.Length-4); }
            set 
            {
                _message = value;
                WriteString(value, 4); 
            }
        }
    }
}
