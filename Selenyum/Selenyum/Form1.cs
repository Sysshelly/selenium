using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenyum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("http://google.com");
                IWebElement element = driver.FindElement(By.Name("q"));
                element.SendKeys("instagram");
                element.Submit();
            
            
        }
    }
}
