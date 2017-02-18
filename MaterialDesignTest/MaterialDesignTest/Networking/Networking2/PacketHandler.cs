using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using MaterialDesignTest.Networking.Networking2;
using MaterialDesignTest.Networking.Networking2.Packets;

namespace MaterialDesignTest.Networking.Networking2
{
    


    
    public static class PacketHandler
    {
        //public static  PacketReceiver me;
        //public static PacketReceiverHandler mypack = onrecv;
        public static IPublisher<string> msgPublisher;
        
        
        
        
        
        

        public static void Hander(byte[] packet, Socket clientSocket)
        {
            ushort packetLength = BitConverter.ToUInt16(packet, 0);
            ushort packetType = BitConverter.ToUInt16(packet, 2);
            

            
            Console.WriteLine("Received packet! Length: {0} | Type: {1}", packet.Length, packetType);
            
            switch (packetType)
            {
                case 1:

                    
                    Console.WriteLine("msg received");
                    
                    MyMessage msg = new MyMessage(packet);
                    //Form1.hello.PublishData(msg.Text);
                    //msgPublisher.PublishData(msg.Text);
                    //Init(msg.Text);
                    break;
            }
            
            

        }
        /*public static void  Init(string data)
        {
            me = new PacketReceiver();
            me.PacketReceived += mypack;
            me.MyMSG += data;

            
           
        }
        static void onrecv(object sender, PacketReceiverEventArgs e)
        {
            Console.WriteLine("if it managed to get " + e.Data + " then we are probably good.");
        }

        */







        
    }
    
   
    
   
    
}
