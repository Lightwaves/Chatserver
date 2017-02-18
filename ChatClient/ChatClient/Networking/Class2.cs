using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace ChatClient.Networking
{
    public class ServerSocket
    {

        private Socket _socket;

        public ServerSocket()
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);

        }




        public class Message
        {
            public ushort opcode;
            public string message;

        }





    }
}
