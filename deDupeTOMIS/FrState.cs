using System;
using System.Windows.Forms;
using cv = OpenCvSharp;

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
