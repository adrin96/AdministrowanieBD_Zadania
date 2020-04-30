using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Uwierzytelnianie
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            komunikat("button1");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            komunikat("button2");
        }

        private void komunikat(string who)
        {
            if (CzyDobryLoginHaslo(txtLogin.Text, txtHaslo.Text, who))
            {
                lKomunikat.ForeColor = System.Drawing.Color.Blue;
                lKomunikat.Text = "Witaj!";
            }
            else
            {
                lKomunikat.ForeColor = System.Drawing.Color.Red;
                lKomunikat.Text = "Spadaj!";
            }

        }

        private bool CzyDobryLoginHaslo(string sLogin, string sHaslo, string who)
        {
            string connectionString = "Data Source=.;Initial Catalog=UserSQL;Integrated Security=True";
            bool bOk = false;
            try
            {
                if (who.Equals("button1"))
                {
                    int? x = 0;
                    DataClasses1DataContext dcContext = new DataClasses1DataContext(@connectionString);
                    dcContext.SprawdzHaslo(sLogin, sHaslo,ref x);
                    if (x > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                    //var wynik = from l in dcContext.Uzytkownicies
                    //            where (l.Login == sLogin) && (l.Haslo == sHaslo)
                    //            select l.Login;
                    //return (wynik.Count() != 0);

                }
                if (who.Equals("button2"))
                {
                   
                    SqlConnection cnUsers = new SqlConnection(@connectionString);
                    SqlParameter parLogin = new SqlParameter("PLogin", sLogin);
                    SqlParameter parHaslo = new SqlParameter("PHaslo", sHaslo);
                    SqlParameter ileParametr = new SqlParameter("@ile", 0);
                    ileParametr.Direction = ParameterDirection.Output;


                    string SQLString = "SELECT * FROM Uzytkownicy WHERE Login=@PLogin AND Haslo=@PHaslo";
                    SqlCommand sqlCommand = new SqlCommand(SQLString, cnUsers);
                    
                    sqlCommand.Parameters.Add(parLogin);
                    sqlCommand.Parameters.Add(parHaslo);
                    sqlCommand.Parameters.Add(ileParametr);

                    sqlCommand.Connection.Open();
                    sqlCommand.ExecuteNonQuery();

                    SqlDataAdapter daUsers = new SqlDataAdapter(sqlCommand);
                    DataSet dsUsers = new DataSet();
                    daUsers.Fill(dsUsers);
                    bOk = (dsUsers.Tables[0].Rows.Count > 0);


                    return bOk;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }


    }
}