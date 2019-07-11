using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcQuickStartTabs.Models
{
    public class ChannelGroup
    {
        public string Message { get; set; }

        public string GetColor()
        {
            Message = "ChannelGroup.cs says: 'You picked";
            return Message;
        }
    }
}

