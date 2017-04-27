using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireRTCSpammer
{
    class Program
    {
        //Hide console stuff.
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        //Info storage.
        public static string email;
        public static string password;
        public static string phoneNumber = "";
        public static int timeToWait;

        //Have we told the user to press 'accept' on the microphone pop-up?
        private static bool hasAuthenticated = false;

        static void Main(string[] args)
        {
            //Hide CMD window for the time being.
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);

            //Open the main user interface.
            MainForm mf = new MainForm();
            mf.ShowDialog();

            //If the user enters invalid credentials..
            tryAuthenticationAgain:

            //Start Chrome.
            ChromeDriver cd = new ChromeDriver();
            ShowWindow(handle, SW_SHOW);
            cd.Manage().Window.Maximize();

            //Sign in..
            cd.Url = "https://phone.firertc.com/auth/sign_in";
            cd.FindElement(By.Id("user_email")).SendKeys(email);
            cd.FindElement(By.Id("user_password")).SendKeys(password);
            cd.FindElement(By.Name("commit")).Click();

            Thread.Sleep(3000);

            //After the user has attempted authentication, if the e-mail field to login is still visible, assume we failed the authentication process.
            try
            {
                cd.FindElementById("user_email");
                cd.Close();
                ShowWindow(handle, SW_HIDE);
                MessageBox.Show("You failed to provide the program with proper credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainForm ms = new MainForm();
                ms.ShowDialog();
                goto tryAuthenticationAgain;
            }
            catch { } //Good, the user authenticated successfully.

            //We will go here after every call completion.
            startSpam:

            //Go to FireRTC's setting page.
            cd.Url = "https://phone.firertc.com/settings";

            //Wait a little bit and accept the alert that comes up.
            Thread.Sleep(1000);
            try { cd.SwitchTo().Alert().Accept(); } catch { } //This is a try-catch because the first call we go through, there will be no alert.

            //Generate a random phone number.
            Random rand = new Random();
            List<int> randomNumbers = new List<int>();
            string largeNumber = "";
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    //Start the first number in the phone number with at least a one. Otherwise, FireRTC will reject the new number.
                    randomNumbers.Add(rand.Next(1, 10));
                }
                else
                {
                    //If the number isn't the first number, add any number, including zero.
                    randomNumbers.Add(rand.Next(0, 10));
                }
            }

            //Form everything together to create our fake phone number.
            foreach (int i in randomNumbers)
            {
                largeNumber += i.ToString();
            }

            //Send the spoofed number to FireRTC.
            cd.FindElement(By.Id("address_ua_config_display_name")).Clear();
            cd.FindElement(By.Id("address_ua_config_display_name")).SendKeys(largeNumber);
            var c = cd.FindElements(By.ClassName("form-group"));
            foreach (IWebElement element in c)
            {
                element.Click();
            }

            //Go to the phone.
            cd.Url = "https://phone.firertc.com/phone";

            //If we haven't already told the user to 'Allow' microphone access, tell them.
            if (!hasAuthenticated)
            {
                MessageBox.Show("Please click 'Allow' on the Chrome window to allow microphone access (if it shows up), then press 'OK' here. (You will only need to do this once)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hasAuthenticated = true;
            }

            //Wait three seconds for the phone URL to pop-up.
            Thread.Sleep(3000);

            //Check if FireRTC unregistered itself.
            try
            {
                var connectButton = cd.FindElementsByClassName("row");
                foreach (IWebElement i in connectButton)
                {
                    if (i.GetAttribute("innerText").Contains("Connect"))
                    {
                        i.Click();
                    }
                }
                Thread.Sleep(2000);
            }
            catch (Exception e) { Console.WriteLine(e.ToString()); } //Cool, FireRTC didn't unregister itself.

            //FireRTC wouldn't let us type directly in the phone text field, so this just presses the corresponding numbers on the number pad.
            foreach (char ch in phoneNumber)
            {
                cd.FindElement(By.Id("button_" + ch)).Click();
            }

            //Call the victim!
            bool hasClicked = false;
            var d = cd.FindElements(By.ClassName("btn"));
            foreach (IWebElement e in d)
            {
                if (!hasClicked)
                {
                    e.Click();
                    hasClicked = true;
                }
            }

            Thread.Sleep(timeToWait);
            goto startSpam;
        }
    }
}
