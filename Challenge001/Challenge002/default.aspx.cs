using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge002
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            int  myResult = int.Parse(firstTextBox.Text) + int.Parse(secondTextBox.Text);
            resultLabel.Text = myResult.ToString();
        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            int myResult = int.Parse(firstTextBox.Text) - int.Parse(secondTextBox.Text);
            resultLabel.Text = myResult.ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            int myResult = int.Parse(firstTextBox.Text) * int.Parse(secondTextBox.Text);
            resultLabel.Text = myResult.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            double myResult = double.Parse(firstTextBox.Text) / double.Parse(secondTextBox.Text);
            resultLabel.Text = myResult.ToString();
        }
    }
}