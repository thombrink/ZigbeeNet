using System;
using System.Collections.Generic;
using System.Text;
using ZigBeeNet.ZCL.Protocol;

namespace ZigBeeNet.ZCL.Clusters.Basic
{
    public class ResetToFactoryDefaultsCommand : ZclCommand
    {
        /**
        * Default constructor.
        */
        public ResetToFactoryDefaultsCommand()
        {
            GenericCommand = false;
            ClusterId = 0;
            CommandId = 0;
            CommandDirection = ZclCommandDirection.CLIENT_TO_SERVER;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder(32);
            builder.Append("ResetToFactoryDefaultsCommand [");
            builder.Append(base.ToString());
            builder.Append(']');
            return builder.ToString();
        }
    }
}
