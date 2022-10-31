using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace _111_1MIDDEMO1 {
    public partial class Q1 : System.Web.UI.Page {
        string[] s_IdSet = new string[3] { "A123456789", "P123456789", "YD321" };

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void tb_Account_TextChanged(object sender, EventArgs e)
        {
            string shelly = tb_Account.Text;
            foreach (string s in s_IdSet)
            {
                if (s ==shelly)
                {
                    lb_Type.Text = "複診";
                    break;
                }
                else lb_Type.Text = "初診";

            }
            if (shelly=="") btn_Submit.Visible=false;
            else btn_Submit.Visible=true;
            pl_Msg.Visible=false;
        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            pl_Msg.Visible=true;
            lb_Msg.Text =lb_Type.Text+"<br />"+tb_Account.Text+"先生小姐，已完成掛號。"+"<br />";
            if (tb_phone.Text!="")
            {
                lb_Msg.Text +="連絡電話為041111111"+tb_phone.Text+"<br />";
            }
        }
    }
}