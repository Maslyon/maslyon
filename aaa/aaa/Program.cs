using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("https://accounts.spotify.com/tr/login?continue=https:%2F%2Fopen.spotify.com%2F");

string a = ("ibrahimgdemir1@gmail.com");
string b = ("ibrahimgdemir2@gmail.com");
string c = ("ibrahimgdemir3@gmail.com");
string d = ("ibrahimgdemir4@gmail.com");
string e = ("ibrahimgdemir5@gmail.com");
string f = ("ibrahimgdemir6@gmail.com");
string g = ("ibrahimgdemir7@gmail.com");
string h = ("ibrahimgdemir8@gmail.com");
string i = ("ibrahimgdemir9@gmail.com");
string j = ("ibrahimgdemir10@gmail.com");

string sifre = ("a1s2d3qwe");

IWebElement username = driver.FindElement(By.Id("login-username"));
IWebElement password = driver.FindElement(By.Id("login-password"));
IWebElement giris = driver.FindElement(By.Id("login-button"));



username.SendKeys(a);
password.SendKeys(sifre);
giris.Click();

System.Threading.Thread.Sleep(8000);
//driver.Navigate().GoToUrl("https://open.spotify.com/search");



//System.Threading.Thread.Sleep(5000);

//IWebElement aratext = driver.FindElement(By.XPath("//input[@class='_748c0c69da51ad6d4fc04c047806cd4d-scss f3fc214b257ae2f1d43d4c594a94497f-scss']"));
//aratext.SendKeys("LDD Türkçe Rap");

//System.Threading.Thread.Sleep(5000);

//IWebElement lddtıkla = driver.FindElement(By.XPath("//div[@class='_85fec37a645444db871abd5d31db7315-scss']"));
//lddtıkla.Click();

//System.Threading.Thread.Sleep(5000);

//IWebElement sec = driver.FindElement(By.XPath("//div[@aria-rowindex='2']"));
//sec.Click();

string sarkibaglan;
Console.WriteLine("Sarki baglantisini yapistir.");
sarkibaglan = Convert.ToString(Console.ReadLine());
System.Threading.Thread.Sleep(8000);
driver.Navigate().GoToUrl(sarkibaglan);

System.Threading.Thread.Sleep(5000);

IWebElement sarkisec = driver.FindElement(By.XPath("//div[@class='bc1fe098cc33981dc67049628a2cac6b-scss']"));
sarkisec.Click();

System.Threading.Thread.Sleep(2000);

IWebElement sarkibaslat = driver.FindElement(By.XPath("//button[@class='_38168f0d5f20e658506cd3e6204c1f9a-scss']"));
sarkibaslat.Click();

System.Threading.Thread.Sleep(2000);

IWebElement loop = driver.FindElement(By.XPath("//button[@class='ebfd411a126f1e7bea6133f21b4ef88e-scss']"));
loop.Click();

IWebElement mute = driver.FindElement(By.XPath("//button[@class='volume-bar__icon-button control-button']"));
mute.Click();


IWebElement element = driver.FindElement(By.TagName("body"));
System.Threading.Thread.Sleep(2500);
element.SendKeys(OpenQA.Selenium.Keys.Control + "t");










