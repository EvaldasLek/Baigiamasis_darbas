namespace Framework.Pages
{
    public class Home
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.eoltas.lt/lt-lt");
        }

        public static void CloseNewsletter()
        {
            string locator = "//*[@id='omnisend-form-651bc69d6aaa52e6ef78c5c4-close-action']";
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        public static void CloseNewsletterMinimized()
        {
            string locator = "//*[@id='omnisend-form-651bc69d6aaa52e6ef78c5c4-teaser-close-btn']";
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        public static void CloseCookies()
        {
            string locator = "//*[@class='cookies-box__inner']//button";
            Common.ClickElement(locator);
        }
    }
}
