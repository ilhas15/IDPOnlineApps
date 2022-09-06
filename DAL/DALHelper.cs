using Dapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IDPOnlineApps.DAL
{
    public class DALHelper
    {
        public string StoredProcedure(DynamicParameters parameters, String Spname, String Conn)
        {
            //string result;
            ConnectionStringSettings dbConnString = ConfigurationManager.ConnectionStrings[Conn];
            IDbConnection db = new SqlConnection(dbConnString.ConnectionString);

            try
            {
                var StoredProcedure = db.Query<dynamic>(Spname, parameters,
                   commandType: CommandType.StoredProcedure).ToList();

                return JsonConvert.SerializeObject(StoredProcedure, Formatting.Indented);

            }
            catch (Exception ex)
            {

                return JsonConvert.SerializeObject(ex); ;
            }
        }

        //public DataTable ExecuteSP(string conimConn, string SP_NAME, SqlCommand sqlCommand)
        //{
        //    DataTable dt = new DataTable();
        //    using (SqlConnection conn = new SqlConnection(conimConn))
        //    {


        //        //SqlCommand cmd = new SqlCommand(SP_NAME, conn)
        //        //{
        //        //    CommandType = CommandType.StoredProcedure
        //        //};
        //        sqlCommand.CommandText = SP_NAME;
        //        sqlCommand.Connection = conn;
        //        sqlCommand.CommandType = CommandType.StoredProcedure;

        //        try
        //        {
        //            conn.Open();
        //            var user = sqlCommand.ExecuteScalar();

        //            SqlDataAdapter dataAdapt = new SqlDataAdapter();
        //            dataAdapt.SelectCommand = sqlCommand;

        //            dataAdapt.Fill(dt); 
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        } 
                
        //    }
        //    return dt;
        //}
    }
}