namespace VideoAccess
{
    public static class Globals
    {
        public static bool VideoAccess { get; set; } = false;
        public static string Username { get; set; } = "";
        public static string EmailAddress { get; set; } = "";

        public static void ResetValues()
        {
            VideoAccess = false;
            Username = "";
            EmailAddress = "";
                    }
    }

}
