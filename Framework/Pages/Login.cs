namespace Framework.Pages
{
    public class Login
    {


        public static void EnterEmailAddress(string email)
        {
            string locator = "//*[@id=\'login-email\']";
            Common.SendKeysToElement(locator, email);
        }

        public static void EnterPassword(string password)
        {
            string locator = "//*[@id='login - password']";
            Common.SendKeysToElement(locator, password);
        }

        public static void ClickMenuButtonPrisijungti()
        {
            string locator = "(//";
            Common.ClickElement(locator);
        }

        public static void ClickButtonPrisijungti()
        {
            string locator = "//";
            Common.ClickElement(locator);
        }

    }
}