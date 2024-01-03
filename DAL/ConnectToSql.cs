using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class ConnectToSql
    {
        //string strCon = @"Data Source=SQL5106.site4now.net;Initial Catalog=db_a9bbc2_librarymanager;User Id=db_a9bbc2_librarymanager_admin;Password=Hieu2003@";
        string strCon = @"Data Source=.;Initial Catalog=Thu_Vien_EAUT_Latest3;Integrated Security=True";
        public SqlConnection sqlCon = null;

        public void openConnection()
        {
            if(sqlCon == null)
            {
                sqlCon= new SqlConnection(strCon);
            }
            if(sqlCon.State == ConnectionState.Closed) 
            {
                sqlCon.Open();
                
            }
  
        }
        public void closeConnection()
        {
            if(sqlCon != null && sqlCon.State == ConnectionState.Open) 
            { 
                sqlCon.Close();
            }
        }
    }
}
