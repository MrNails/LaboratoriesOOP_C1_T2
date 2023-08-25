using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetLabs.Lab7
{
    public partial class Task2 : Page
    {
        private static readonly int MaxLoginAttemps = 3;
        private static int LoginAttemps = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (LoginAttemps >= MaxLoginAttemps)
            {
                Output.Text = "Ви потратили максимальну кількість спроб!";
                return;
            }

            try
            {
                var login = File.ReadAllText(Server.MapPath(@"login.txt"));
                var password = File.ReadAllText(Server.MapPath(@"pass.txt"));

                if (TextBox1.Text != login)
                {
                    Output.Text = "Такого логіну не існує";
                    LoginAttemps++;
                    return;
                }

                if (TextBox2.Text != password)
                {
                    Output.Text = "Такого паролю не існує";
                    LoginAttemps++;
                    return;
                }

                var name = File.ReadAllText(Server.MapPath(@"my.txt"));
                LoginAttemps = 0;

                Label1.Text = $"Вітаємо, {name}";
                Response.Redirect("Default.aspx");

            }
            catch (Exception ee)
            {
                Output.Text = ee.Message;
                Label1.Text = "Ви не зареєстровані!";
            }
        }
    }
}