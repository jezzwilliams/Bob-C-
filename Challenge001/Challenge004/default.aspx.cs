using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge004
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            myImage.ImageUrl = "\\PapaBob.png";
        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            double myResult = 0.00;

            if (babyRadioButton.Checked)
            {
                myResult = 10.0;

                myResult = (pepperoniCheckBox.Checked) ? myResult + 1.50 : myResult;
                myResult = (onionsCheckBox.Checked) ? myResult + 0.75 : myResult;
                myResult = (greenCheckBox.Checked) ? myResult + 0.50 : myResult;
                myResult = (redCheckBox.Checked) ? myResult + 0.75 : myResult;
                myResult = (anchoviesCheckBox.Checked) ? myResult + 2.00 : myResult;
                myResult = (deepRadioButton.Checked) ? myResult + 2.00 : myResult;

                //double pepperoni = (pepperoniCheckBox.Checked) ? 1.50 : 0.00;
                //double onions = (onionsCheckBox.Checked) ? 0.75 : 0.00;
                //double green = (greenCheckBox.Checked) ? 0.50 : 0.00;
                //double red = (redCheckBox.Checked) ? 0.75 : 0.00;
                //double anchovies = (anchoviesCheckBox.Checked) ? 2.00 : 0.00;
                //double deep = (deepRadioButton.Checked) ? 2.00 : 0.00;

                //myResult = ((pepperoni + onions + green + red + anchovies + deep) + 10);
                //resultLabel.Text = myResult.ToString();

                resultLabel.Text = myResult.ToString();
            }
            else if (mamaRadioButton.Checked)
            {
                myResult = 13.0;

                myResult = (pepperoniCheckBox.Checked) ? myResult + 1.50 : myResult;
                myResult = (onionsCheckBox.Checked) ? myResult + 0.75 : myResult;
                myResult = (greenCheckBox.Checked) ? myResult + 0.50 : myResult;
                myResult = (redCheckBox.Checked) ? myResult + 0.75 : myResult;
                myResult = (anchoviesCheckBox.Checked) ? myResult + 2.00 : myResult;
                myResult = (deepRadioButton.Checked) ? myResult + 2.00 : myResult;

                //double pepperoni = (pepperoniCheckBox.Checked) ? 1.50 : 0.00;
                //double onions = (onionsCheckBox.Checked) ? 0.75 : 0.00;
                //double green = (greenCheckBox.Checked) ? 0.50 : 0.00;
                //double red = (redCheckBox.Checked) ? 0.75 : 0.00;
                //double anchovies = (anchoviesCheckBox.Checked) ? 2.00 : 0.00;
                //double deep = (deepRadioButton.Checked) ? 2.00 : 0.00;

                //myResult = ((pepperoni + onions + green + red + anchovies + deep) + 13);
                resultLabel.Text = myResult.ToString();
            }
            else if (papaRadioButton.Checked)
            {
                myResult = 16.0;

                myResult = (pepperoniCheckBox.Checked) ? myResult + 1.50 : myResult;
                myResult = (onionsCheckBox.Checked) ? myResult + 0.75 : myResult;
                myResult = (greenCheckBox.Checked) ? myResult + 0.50 : myResult;
                myResult = (redCheckBox.Checked) ? myResult + 0.75 : myResult;
                myResult = (anchoviesCheckBox.Checked) ? myResult + 2.00 : myResult;
                myResult = (deepRadioButton.Checked) ? myResult + 2.00 : myResult;
                //double pepperoni = (pepperoniCheckBox.Checked) ? 1.50 : 0.00;
                //double onions = (onionsCheckBox.Checked) ? 0.75 : 0.00;
                //double green = (greenCheckBox.Checked) ? 0.50 : 0.00;
                //double red = (redCheckBox.Checked) ? 0.75 : 0.00;
                //double anchovies = (anchoviesCheckBox.Checked) ? 2.00 : 0.00;
                //double deep = (deepRadioButton.Checked) ? 2.00 : 0.00;

                //myResult = ((pepperoni + onions + green + red + anchovies + deep) + 16);
                resultLabel.Text = myResult.ToString();
            }
            if ((pepperoniCheckBox.Checked && greenCheckBox.Checked && anchoviesCheckBox.Checked) ||
                    (pepperoniCheckBox.Checked && redCheckBox.Checked && onionsCheckBox.Checked))
            {
                myResult -= 2.0;
                resultLabel.Text = myResult.ToString();
            }


        }
    }
}