using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

// Inspired from: https://stackoverflow.com/questions/20841501/blockinput-method-doesnt-work-on-windows-7

namespace blockinput
{
    static class InputBlocker
    {
        [DllImport("user32.dll")]
        static extern bool BlockInput(bool fBlockIt);
    }
}
