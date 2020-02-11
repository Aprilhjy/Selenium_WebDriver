using AutoFramework.UIElements;

namespace AutoFramework
{
    public static class Actions
    {
        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            LoginScenarioPost lspost = new LoginScenarioPost();

            lspost.UsernameField.SendKeys(username);
            lspost.PasswordField.SendKeys(password);
            lspost.RepeatPasswordField.SendKeys(repeatPassword);
            lspost.LoginButton.Click();

        }
    }
}
