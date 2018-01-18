using MySql.Data.MySqlClient;
using System;
using System.Web.UI;

public partial class WebPart_Feedback : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) { }
    }
    protected void Sub_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            try
            {
                using (MySqlConnection SqlCon = new MySqlConnection(SqlHelper.SqlStrig))
                {
                    using (MySqlCommand cmd = new MySqlCommand("Insert into customer_feedback(CustomerName,email,PhoneNo,Comment) values(?CustomerName,?email,?PhoneNo,?Comment)", SqlCon))
                    {
                        cmd.Parameters.Add("?CustomerName", MySqlDbType.VarChar).Value = ConPerson.Text;
                        cmd.Parameters.Add("?email", MySqlDbType.VarChar).Value = email.Text;
                        cmd.Parameters.Add("?PhoneNo", MySqlDbType.VarChar).Value = phnumber.Text;
                        cmd.Parameters.Add("?Comment", MySqlDbType.VarChar).Value = TxtComment.Text;
                        SqlCon.Open();
                        cmd.ExecuteNonQuery();
                        SqlCon.Close();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Message", "Validate('Thank you for your feedback, We will get back to you.',2);", true);

                    }
                }
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Message", "Validate('Unable to save information. Please try after some time.',1);", true);
                writeerrorlogin.errorwrite(ex.StackTrace);
            }
        }

    }
}
