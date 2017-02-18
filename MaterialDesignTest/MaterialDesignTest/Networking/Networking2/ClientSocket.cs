using System;
using System.Net;
using System.Net.Sockets;


namespace MaterialDesignTest.Networking.Networking2
{
    class ClientSocket
    {
        private Socket _socket;
        private byte[] _buffer;

        public ClientSocket()
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }
        public void Connect(string ipAddress, int port)
        {
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
            _socket.BeginConnect(endpoint, ConnectCallback, null);
            
        }
        private void ConnectCallback(IAsyncResult result)

        {
            if (_socket.Connected)
            {
                Console.WriteLine("Connected to the server");
                _socket.EndConnect(result);
                _buffer = new byte[1024];
                _socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, ReceivedCallback, null);
                
                
            }
            else Console.WriteLine("Could not connect. ");
            

        }
        private void ReceivedCallback(IAsyncResult result)
        {
            int bufLength = _socket.EndReceive(result);
            byte[] packet = new byte[bufLength];
            Array.Copy(_buffer, packet, packet.Length);

            //Handle packet
            PacketHandler.Hander(packet, _socket);


            _buffer = new byte[1024];
            _socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, ReceivedCallback, null);

        }
        public void Send(byte[] data)
        {
            _socket.Send(data);
        }
    }
}
