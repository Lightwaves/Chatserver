__author__ = 'Stephen'
#!/usr/bin/env python3
# Foundations of Python Network Programming, Third Edition
# https://github.com/brandon-rhodes/fopnp/blob/m/py3/chapter05/blocks.py
# Sending data over a stream but delimited as length-prefixed blocks.

import socket, struct, multiprocessing, queue
from argparse import ArgumentParser

header_struct = struct.Struct('! H I')

def recvall(sock, length):
    blocks = []
    while length:
        block = sock.recv(length)
        if not block:
            raise EOFError('socket closed with %d bytes left'
                           ' in this block'.format(length))
        length -= len(block)
        blocks.append(block)
    return b''.join(blocks)

def get_block(sock):
    data = recvall(sock, header_struct.size)
    (opcode, block_length) = header_struct.unpack(data)
    return recvall(sock, block_length)

def put_block(sock, opcode, message):
    block_length = len(message)
    values = (opcode, block_length)
    sock.send(header_struct.pack(*values))
    sock.send(message)

def server(address):
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    sock.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
    sock.bind(address)
    sock.listen(1)
    print('Run this script in another window with "-c" to connect')
    print('Listening at', sock.getsockname())
    sc, sockname = sock.accept()
    print('Accepted connection from', sockname)
    while True:
        block = get_block(sc)
        if not block:
            break
        print('Block says:', repr(block))


