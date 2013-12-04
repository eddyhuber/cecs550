using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;

public partial class Forum : System.Web.UI.Page
{
    private const string AntiXsrfTokenKey = "__AntiXsrfToken";
    private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
    private string _antiXsrfTokenValue;
    //string dbConnectionString = "Data Source=ZAGREUS-PC\\SQLexpress;Initial Catalog=aspnet-CrazyTrades-20131109203040;Integrated Security=SSPI;";
    string dbConnectionString = "Data Source=ZAGREUS-PC\\SQLexpress;Initial Catalog=aspnet-CrazyTrades-20131109203040;Integrated Security=SSPI;";

    protected void Page_Load(object sender, EventArgs e)
    {
        label1.Text = "";
        if (!IsPostBack)
        {
            string tokenz = Request.Cookies[AntiXsrfTokenKey].Value;
            string usernamez = Context.User.Identity.Name ?? String.Empty;
            if (usernamez == String.Empty)
            {
                Response.Redirect("Forum.aspx");
            }
        }

    }
    protected void Submitcreate(object sender, EventArgs e)
    {
        string textb = textboxfield.Value.ToString();
        string textarea = textareafield.Value.ToString().Replace(System.Environment.NewLine, "<br />");
        label1.Text = "";
        if (textb == "")
        {
            label1.Text = "A subtitle is required ";

        }
        if (textarea == "")
        {
            label1.Text += "A message is required <br />";
        }
        if (textb != "" && textarea != "")
        {
            string usernamez = Context.User.Identity.Name ?? String.Empty;
            if (usernamez != String.Empty)
            {
                Dostore(usernamez, textb, textarea);

            }
        }
    }
	

    //public SomeMethod(string fName)
    //{
    //    var con = ConfigurationManager.ConnectionStrings["Yourconnection"].ToString();

    //    Person matchingPerson = new Person();
    //    using (SqlConnection myConnection = new SqlConnection(con))
    //    {
    //        string oString = "Select * from Employees where FirstName=@fName";
    //        SqlCommand oCmd = new SqlCommand(oString, myConnection);
    //        oCmd.Parameters.AddWithValue("@Fname", fName);           
    //        myConnection.Open();
    //        using (SqlDataReader oReader = oCmd.ExecuteReader())
    //        {
    //            while (oReader.Read())
    //            {    
    //                matchingPerson.firstName = oReader["FirstName"].ToString();
    //                matchingPerson.lastName = oReader["LastName"].ToString();                       
    //            }

    //            myConnection.Close();
    //        }               
    //    }
    //    return matchingPerson;
    //}

    void Dostore(string username, string subtitle, string message)
    {
        
        try
        {
            using (SqlConnection sqlConnection = new SqlConnection(dbConnectionString))
            {
                SqlCommand command = new SqlCommand("sp_Text", sqlConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@username_P", System.Data.SqlDbType.NVarChar).Value = username;
                command.Parameters.Add("@Topic", System.Data.SqlDbType.NVarChar).Value = "";
                command.Parameters.Add("@Subtitle", System.Data.SqlDbType.NVarChar).Value = subtitle;
                command.Parameters.Add("@Message", System.Data.SqlDbType.NVarChar).Value = message;
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();

            }
            Response.Redirect("Forum.aspx");
        }
        catch (SqlException ex)
        {
            Console.WriteLine("SQL Error" + ex.Message.ToString());
            //return 0;
        }
    }
}



