using OpenCvSharp;

namespace deDupeTOMIS
{
    public static class FrState
    {
        public static Mat imgWorking;

        public static bool TemplateTrained { get; set; }
    }

    public class C
    {
        public static float phi = (float)((1.0+System.Math.Sqrt(5.0))/2.0);
    }
}
