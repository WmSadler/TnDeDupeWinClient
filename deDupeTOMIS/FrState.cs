using OpenCvSharp;

namespace deDupeTOMIS
{
    public static class FrState
    {
        static bool _ippConnected;
        static bool _tomisDbConnected;
        static bool _templateDbConnected;
        public static Mat imgWorking;

        public static bool ippConnected
        {
            get
            {
                return _ippConnected;
            }
            set
            {
                _ippConnected = value;
            }
        }

        public static bool tomisDbConnected
        {
            get
            {
                return _tomisDbConnected;
            }
            set
            {
                _tomisDbConnected = value;
            }
        }

        public static bool templateDbConnected
        {
            get
            {
                return _templateDbConnected;
            }
            set
            {
                _templateDbConnected = value;
            }
        }
    }
}
