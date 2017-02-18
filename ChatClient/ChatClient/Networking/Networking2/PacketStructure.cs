﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net;

namespace ChatClient.Networking
{
    public abstract class PacketStructure
    {
        private byte[] _buffer;
        public PacketStructure(ushort Length, ushort type)
        {
            _buffer = new byte[Length+4];
            WriteUShort(type, 0);
            WriteUShort(Length, 2);
            
        }
        public PacketStructure(byte[] packet)
        {
            _buffer = packet;
        }
        public void WriteUShort(ushort value, int offset)
        {
            byte[] tempBuf = new byte[2];
            tempBuf = BitConverter.GetBytes(value);
            Buffer.BlockCopy(tempBuf, 0, _buffer, offset, 2);
        }
        public ushort ReadUShort(int offset)
        {
            return BitConverter.ToUInt16(_buffer, offset);
        }
        public void WriteUInt(uint value, int offset)
        {
            byte[] tempBuf = new byte[4];
            tempBuf = BitConverter.GetBytes(value);
            Buffer.BlockCopy(tempBuf, 0, _buffer, offset, 4);
        }
        public void WriteString(string value, int offset)
        {
            
            byte[] tempBuf = new byte[value.Length];
            tempBuf = Encoding.UTF8.GetBytes(value);
            Buffer.BlockCopy(tempBuf, 0, _buffer, offset, value.Length);

        }
        public string ReadString(int offset, int count)
        {
            return Encoding.UTF8.GetString(_buffer, offset, count);
        }

        public void RewriteHeader(ushort length, ushort type)
        {
            WriteUShort(length, 0);
            WriteUShort(type, 2);



        }
        public byte[] Data { get { return _buffer; } }


    }
}

