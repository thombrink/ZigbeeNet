﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZigBeeNet.CC.Packet.ZDO
{
    public class ZDO_NWK_ADDR_REQ_SRSP : ZToolPacket
    {
        /// <name>TI.ZPI1.ZDO_NWK_ADDR_REQ_SRSP.Status</name>
        /// <summary>Status</summary>
        public int Status { get; private set; }

        /// <name>TI.ZPI1.ZDO_NWK_ADDR_REQ_SRSP</name>
        /// <summary>Constructor</summary>
        public ZDO_NWK_ADDR_REQ_SRSP()
        {
        }

        public ZDO_NWK_ADDR_REQ_SRSP(byte[] framedata)
        {
            this.Status = framedata[0];
            BuildPacket(new DoubleByte(ZToolCMD.ZDO_NWK_ADDR_REQ_SRSP), framedata);
        }

        public override string ToString()
        {
            return "ZDO_NWK_ADDR_REQ_SRSP{Status=" + Status + '}';
        }
    }
}
