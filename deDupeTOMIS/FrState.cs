using OpenCvSharp;

namespace deDupeTOMIS
{
    public static class FrState
    {
        static bool _loggedIn;
        public static string UserId;
        public static string Password;
        public static Mat imgWorking;

        public static bool loggedIn { get; set; }
        public static bool ippConnected { get; set; }
        public static bool tomisDbConnected { get; set; }
        public static bool templateDbConnected { get; set; }
    }

    public class C
    {
        public static float phi = (float)((1.0+System.Math.Sqrt(5.0))/2.0);
    }
}
