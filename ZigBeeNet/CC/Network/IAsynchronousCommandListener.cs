﻿using System;
using System.Collections.Generic;
using System.Text;
using ZigBeeNet.CC.Packet;

namespace ZigBeeNet.CC.Network
{
    public interface IAsynchronousCommandListener
    {
        /// <summary>
        /// Called when asynchronous command has been received.
        /// </summary>
        /// <param name="packet"></param>
        void ReceivedAsynchronousCommand(ZToolPacket packet);

        /// <summary>
        /// Called when unclaimed synchronous command response has been received.
        /// </summary>
        /// <param name="packet"></param>
        void ReceivedUnclaimedSynchronousCommandResponse(ZToolPacket packet);
    }
}
