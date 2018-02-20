using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int k = 0;
        if (RadioButtonList1.SelectedIndex == 1)
        {
            k++;
        }
        if (RadioButtonList2.SelectedIndex == 0)
        {
            k++;
        }
        if (RadioButtonList3.SelectedIndex == 2)
        {
            k++;
        }
        int i;
        i = TextBox1.Text.Length;
        if ((!IsNumeric(TextBox1.Text)))
        {
            Error.Visible = true;
            TextBox1.Text = "";
            int p = TextBox1.Text.Length;
            Error.Text = "Error su rut ";
            k = 0;
        }
        else
        {
            if (i < 7)
            {
                Error.Visible = true;
                TextBox1.Text = "";
                int p = TextBox1.Text.Length;
                Error.Text = "Error su rut";
                k = 0;
            }
            else
            {
                int t = TextBox1.Text.Length;
                Error.Visible = false;
                Label5.Text = "su pintaje es " + k + "enviado correctamente" + " y su rut tiene " + t + "digitos";

            }
        }
        
    }
    private bool IsNumeric(string n)
    {
        try
        {
            double x = Convert.ToDouble(n);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

}