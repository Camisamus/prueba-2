using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "")
        { Label5.Text = "llene todos los campos"; }
        else
        {
            if (TextBox2.Text == "")
            { Label5.Text = "llene todos los campos"; }
            else
            {
                if (TextBox3.Text == "")
                { Label5.Text = "llene todos los campos"; }
                else
                {
                    if (TextBox4.Text == "")
                    { Label5.Text = "llene todos los campos"; }
                    else
                    {
                        var numeros = "@";
                        for (int i = 0; i < TextBox4.Text.Length; i++)
                        {
                            if (TextBox4.Text.Contains(numeros))
                            {
                                Label5.Text = "enviado";
                            }
                        }
                    }
                }
            }
        }

    }
}