using System;
using System.Net.Mail;
using System.Text;
using System.Web.UI;

namespace DotNetLabs.Lab7
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var labelRes = new StringBuilder();
            if (TextBox1.Text.ToLower().StartsWith("в"))
            {
                labelRes.Append("Прізвище починається з літери В<br />");
            }

            if (TextBox2.Text.ToLower().StartsWith("в"))
            {
                labelRes.Append("Ім'я починається з літери В<br />");
            }

            if (TextBox3.Text.ToLower().StartsWith("в"))
            {
                labelRes.Append("По-батькові починається з літери В<br />");
            }

            if (TextBox4.Text.ToLower().StartsWith("в"))
            {
                labelRes.Append("E-mail починається з літери В<br />");
            }
            
            bool errorMail = string.IsNullOrWhiteSpace(TextBox4.Text);

            if (!errorMail)
            {
                try
                {
                    var m = new MailAddress(TextBox4.Text);
                }
                catch (FormatException)
                {
                    errorMail = true;
                }
            }

            if (errorMail)
            {
                labelRes.Append("E-mail не правильно введений");
            }

            Label1.Text = labelRes.ToString();
        }
    }
}