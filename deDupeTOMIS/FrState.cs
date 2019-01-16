using OpenCvSharp;

namespace deDupeTOMIS
{
    public static class FrState
    {
        public static string UserId;
        public static string Password;
        public static Mat imgWorking;

        public static bool LoggedIn { get; set; }
        public static bool IppConnected { get; set; }
        public static bool TomisDbConnected { get; set; }
        public static bool TemplateDbConnected { get; set; }
    }

    public class C
    {
        public static float phi = (float)((1.0+System.Math.Sqrt(5.0))/2.0);
    }
}
