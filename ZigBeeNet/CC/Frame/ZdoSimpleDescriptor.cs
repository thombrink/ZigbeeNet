﻿using System;
using System.Collections.Generic;
using System.Text;
using ZigBeeNet.CC.Packet;
using ZigBeeNet.ZDO;

namespace ZigBeeNet.CC.Frame
{
    public class ZdoSimpleDescriptor : TiDongleReceivePacket
    {

        public static ZigBeeApsFrame Create(ZToolPacket packet)
        {
            ZigBeeApsFrame apsFrame = new ZigBeeApsFrame();
            apsFrame.Cluster = ZdoCommandType.GetValueByType(ZdoCommandType.CommandType.SIMPLE_DESCRIPTOR_RESPONSE).ClusterId;
            apsFrame.DestinationEndpoint = 0;
            apsFrame.SourceAddress = (ushort)(packet.Packet[4] | (packet.Packet[5] << 8));
            apsFrame.SourceEndpoint = 0;
            apsFrame.Profile = 0;

            Array.Copy(packet.Packet, 6, apsFrame.Payload, 0, packet.Packet.Length - 7);

            return apsFrame;
        }
    }
}
