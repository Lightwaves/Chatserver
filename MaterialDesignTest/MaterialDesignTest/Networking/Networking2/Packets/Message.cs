using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialDesignTest.Networking.Networking2.Packets
{
    class MyMessage : PacketStructure
    {
        private string _message;
        
        public MyMessage(string message, ushort opcode)
            : base((ushort)(message.Length), opcode)
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
