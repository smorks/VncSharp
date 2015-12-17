using System;
using System.Drawing;

namespace VncSharp
{
    public class VncDesktopSizeChangedArgs : EventArgs
    {
        public Size DesktopSize;

        public VncDesktopSizeChangedArgs(Size desktopSize)
        {
            DesktopSize = desktopSize;
        }
    }
}
