using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    public class Class1
    {
        [Test]
        public void Demo()
        {
            Driver.InitializeDriver();
            Home.Open();
            //Home.CloseNewsletter();
            //Home.CloseNewsletterMinimized();
            Home.CloseCookies();
        }
    }
}
