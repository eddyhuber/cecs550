using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Forum : System.Web.UI.Page
{
    private const string AntiXsrfTokenKey = "__AntiXsrfToken";
    private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
    private string _antiXsrfTokenValue;
    //string dbConnectionString = "Data Source=ZAGREUS-PC\\SQLexpress;Initial Catalog=aspnet-CrazyTrades-20131109203040;Integrated Security=SSPI;";
    string dbConnectionString = "Data Source=ZAGREUS-PC\\SQLexpress;Initial Catalog=aspnet-CrazyTrades-20131109203040;Integrated Security=SSPI;";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            //for use with checking user info and posting
            string tokenz = Request.Cookies[AntiXsrfTokenKey].Value;
            string usernamez = Context.User.Identity.Name ?? String.Empty;
        }
        if (IsPostBack)
        {
            createbt.Visible = false;
        }
        
    }
    protected string LoadPost(string id)
    {
        string rstr = "";
        SqlDataReader reader;
        string querystr = "Select * from Post Where PostID='" + id + "'";
        
        try
        {
            using (SqlConnection sqlConnection = new SqlConnection(dbConnectionString))
            {
                SqlCommand command = new SqlCommand(querystr, sqlConnection);
                //command.CommandType = System.Data.CommandType.;

                sqlConnection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rstr = ReadSingleRowALL((IDataRecord)reader) + rstr;
                }
                sqlConnection.Close();

            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("SQL Error" + ex.Message.ToString());
            //return 0;
        }
        return rstr;
    }
    protected string  DoRead()
    {
        string usernamez = Context.User.Identity.Name ?? String.Empty;
        string rstr = "<div class=\"post\" onclick=\"myFunction(0)\">"
                + "<div class=\"subtitlebox\" \">"
                    + "Wecome To The Forums!"
                + "</div> \n"
                + "<div class=\"messagebox\"\">"
                    + "<p>" 
                    + "Thank you for visiting the Forums where you can find options on many different stocks. <br />"
                    + "Feel free to ask questions!" + "......."
                    + "</p>"
               + "</div> \n"
            + "</div>"
        +"<hr width=\"100%\" style=\"border: 2px dashed #C0C0C0\" color=\"#FFFFFF\" size=\"6\">";;
        if (IsPostBack)
        {
            rstr = "";

        }
        if (usernamez != String.Empty && !IsPostBack)
        {
            SqlDataReader reader;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(dbConnectionString))
                {
                    SqlCommand command = new SqlCommand("fetchPost", sqlConnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    sqlConnection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        rstr = ReadSingleRow((IDataRecord)reader) + rstr;
                    }
                    sqlConnection.Close();

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                //return 0;
            }
        }
        return rstr;
    }
    private string ReadSingleRow(IDataRecord record)
    {
        String r=String.Format("{0}, {1}, {2}, {3}, {4}", record[0], record[1], record[2], record[3], record[4]);
        int id = (int)record[0];
        string user = record[1].ToString();
        string subt = record[3].ToString();
        string message = record[4].ToString();
        if (message.Length >50)
            message = message.Substring(0, 50);

        string astr = "<div class=\"post\" onclick=\"myFunction("+ id +")\">"
                + "<div class=\"subtitlebox\" \">"
                    + subt
                + "</div> \n"
                + "<div class=\"messagebox\"\">"
                    + "<p>" + message + "......."
                    + "</p>"
               + "</div> \n"
            + "</div>"
        +"<hr width=\"100%\" style=\"border: 2px dashed #C0C0C0\" color=\"#FFFFFF\" size=\"6\">";
        return astr;
    }
    private string ReadSingleRowALL(IDataRecord record)
    {
        String r = String.Format("{0}, {1}, {2}, {3}, {4}", record[0], record[1], record[2], record[3], record[4]);
        int id = (int)record[0];
        string user = record[1].ToString();
        string subt = record[3].ToString();
        string message = record[4].ToString();


        string astr = "<div>"
                + "<div class=\"subtitlebox\" \">"
                    + subt
                + "</div> \n"
                + "<div class=\"messagebox\"\">"
                    + "<p>" + message
                    + "</p>"
               + "</div> \n"
            + "</div>"
            + "<input type=\"button\" value=\"Replay\" /> <input type=\"button\" value=\"Delete\" />"
        + "<hr width=\"100%\" style=\"border: 2px dashed #C0C0C0\" color=\"#FFFFFF\" size=\"6\">";
        
        return astr;
    }
    void master_Page_PreLoad(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string tokenz = Request.Cookies[AntiXsrfTokenKey].Value;
            string usernamez = Context.User.Identity.Name ?? String.Empty;
            
        }
     
    }
    protected void CreateNewPost(object sender, EventArgs e)
    {

    }

}