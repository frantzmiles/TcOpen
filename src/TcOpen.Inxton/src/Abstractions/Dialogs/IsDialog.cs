﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vortex.Connector;

namespace TcOpen.Inxton.Dialogs
{
    public interface IsDialog : IVortexObject
    {
        string DialogId { get; set; }

        void ShowAgainIfInvoked();
        void Initialize(Action dialogAction);
        
    }
}
