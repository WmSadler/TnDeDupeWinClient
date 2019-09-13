using System;

namespace deDupeTOMIS
{
    public class WhoAmI
    {
        private static String Uid { get; set; }
        private static String Pwd { get; set; }

        private WhoAmI() { }
        public static readonly WhoAmI whoAmI = new WhoAmI();

        public bool Impersonate()
        {
            MessageBox.Show(string.Format("Logged In As @", Uid), "Successful Impersonation");
            return true;
        }
    }
}
