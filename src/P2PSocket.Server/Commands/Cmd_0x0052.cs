﻿using P2PSocket.Core.Commands;
using P2PSocket.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P2PSocket.Server.Commands
{
    [CommandFlag(Core.P2PCommandType.Heart0x0052)]
    public class Cmd_0x0052 : P2PCommand
    {
        readonly P2PTcpClient m_tcpClient;
        byte[] m_data { get; }
        public Cmd_0x0052(P2PTcpClient tcpClient,byte[] data)
        {
            m_tcpClient = tcpClient;
            m_data = data;
        }
        public override bool Excute()
        {
            m_tcpClient.LastHeartTime = DateTime.Now;
            //throw new NotImplementedException();
            return true;
        }
    }
}
