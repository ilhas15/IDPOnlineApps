using Dapper;
using IDPOnlineApps.DAL;
using IDPOnlineApps.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace IDPOnlineApps.Controllers
{
    [SessionState(System.Web.SessionState.SessionStateBehavior.ReadOnly)]
    public class CuriculumController : Controller
    {
        readonly ConnectionStringSettings mySetting = ConfigurationManager.ConnectionStrings["IDP"];
        readonly DataTable DT = new DataTable();
        readonly DALHelper idpDAL = new DALHelper();
        // GET: Curiculum
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Curiculum()
        {
            return View();
        }
        public ActionResult EditCuriculum(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        public ActionResult C_DropdownNameLevel(Curiculum model)
        {
            var dictionary = new Dictionary<string, object>
            {
                { "option", "DROPDOWN Level" },
                { "typelevel", model.TypeLevel },
                
            };
            // Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(parameters.ToString());

            try
            {
                var dynamicParameters = new DynamicParameters(dictionary);
                //return Request.CreateResponse(HttpStatusCode.OK, dynamicParameters);
                var result = idpDAL.StoredProcedure(dynamicParameters, "SP_CuriculumTransaction", "IDP");
                return Json(result);
            }
            catch (Exception ex)
            {
                return Json(new { result = false, error = ex.Message });
            }
        }
        public ActionResult C_TableType()
        {
            var dictionary = new Dictionary<string, object>
            {
                { "option", "TABLE Transaction Head" }

            };
            // Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(parameters.ToString());

            try
            {
                var dynamicParameters = new DynamicParameters(dictionary);
                //return Request.CreateResponse(HttpStatusCode.OK, dynamicParameters);
                var result = idpDAL.StoredProcedure(dynamicParameters, "SP_CuriculumTransaction", "IDP");
                return Json(result);
            }
            catch (Exception ex)
            {
                return Json(new { result = false, error = ex.Message });
            }
            
        }
        public ActionResult C_SaveHeadCuriculum(Curiculum model)
        {
            var dictionary = new Dictionary<string, object>
            {
                { "option", "SAVE Curiculum Head" },
                { "typelevel", model.TypeLevel },
                { "namelevel", model.LevelName },
                { "user", "Ilhas" },
                //{ "typelevel", model.TypeLevel },
            };
            // Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(parameters.ToString());

            try
            {
                var dynamicParameters = new DynamicParameters(dictionary);
                //return Request.CreateResponse(HttpStatusCode.OK, dynamicParameters);
                var result = idpDAL.StoredProcedure(dynamicParameters, "SP_CuriculumTransaction", "IDP");
                return Json(result);
            }
            catch (Exception ex)
            {
                return Json(new { result = false, error = ex.Message });
            }
            //string conSQL = mySetting.ConnectionString;
            //SqlDataAdapter dataAdapter = new SqlDataAdapter();
            //SqlConnection connect = new SqlConnection(conSQL);
            //List<string> ModelData = new List<string>();
            //string result;
            //try
            //{
            //    using (SqlCommand comm = new SqlCommand("SP_CuriculumTransaction", connect))
            //    {
            //        connect.Open();
            //        comm.CommandType = CommandType.StoredProcedure;
            //        comm.Parameters.AddWithValue("@typelevel", model.TypeLevel);
            //        comm.Parameters.AddWithValue("@namelevel", model.LevelName);
            //        comm.Parameters.AddWithValue("@user", "Ilhas");
            //        comm.Parameters.AddWithValue("@option", "SAVE Curiculum Head");
            //        result = (string)comm.ExecuteScalar();
            //        connect.Close();
            //        ModelData.Add(result);
            //    }
            //}
            //catch (Exception e)
            //{

            //    throw e;
            //}
            //return Json(ModelData);
        }
    }
}