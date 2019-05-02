using System;
using System.Windows.Forms;
using cv = OpenCvSharp;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace deDupeTOMIS
{
    public static class FrState
    {
        public static bool TemplateTrained { get; set; }
    }

    public class C
    {
        public static float phi = (float)((1.0+System.Math.Sqrt(5.0))/2.0);
    }
}
