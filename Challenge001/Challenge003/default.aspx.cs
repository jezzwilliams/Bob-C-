using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge003
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void pencilRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pencilRadioButton.Checked)
            {
                resultLabel.Text = "You have chose a pencil as your note taking preference";
                myImage.ImageUrl = "\\pencil.png";
            }
            else if (penRadioButton.Checked)
            {
                resultLabel.Text = "You have chose a pen as your note taking preference";
                myImage.ImageUrl = "\\pen.png";
            }
            else if (phoneRadioButton.Checked)
            {
                resultLabel.Text = "You have chose a phone as your note taking preference";
                myImage.ImageUrl = "\\phone.png";
            }
            else if (tabletRadioButton.Checked)
            {
                resultLabel.Text = "You have chose a Tablet as your note taking preference";
                myImage.ImageUrl = "\\tablet.png";
            }
            else
            {
                resultLabel.Text = "Please select a radio button";
            }




        }
    }
}