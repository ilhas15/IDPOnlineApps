using Dapper;
using IDPOnlineApps.DAL;
using IDPOnlineApps.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
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
        public ActionResult ListTraining()
        {
            return View();
        }
        public ActionResult EditCuriculum(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        public ActionResult SoftCompetency()
        {
            return View();
        }
        public ActionResult HardCompetency()
        {
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
            
        }

        public ActionResult C_GetHeadCuriculum(Curiculum model)
        {
            var dictionary = new Dictionary<string, object>
            {
                { "option", "GET Transaction Head" },
                { "id", model.Id },
                
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
        public ActionResult C_GetScoreDropdown(Curiculum model)
        {
            var dictionary = new Dictionary<string, object>
            {
                { "option", "GET score data" },

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
        public ActionResult C_SaveDetailCuriculum(Curiculum model)
        {
            var dictionary = new Dictionary<string, object>
            {
                { "option", "SAVE Transaction Detail" },
                { "id", model.Id },
                { "title", model.Judul },
                { "deskripsi", model.Deskripsi },
                { "score", model.Score },
                { "user", "Ilhas" },
                { "inactive", model.Isactive },
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
        public ActionResult C_UpdateDetailCuriculum(Curiculum model)
        {
            var dictionary = new Dictionary<string, object>
            {
                { "option", "UPDATE Transaction Detail" },
                { "idDetail", model.IdDetail },
                { "title", model.Judul },
                { "deskripsi", model.Deskripsi },
                { "score", model.Score },
                { "user", "Ilhas" },
                { "inactive", model.Isactive },
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
        public ActionResult C_GetDetailCuriculum(Curiculum model)
        {
            var dictionary = new Dictionary<string, object>
            {
                { "option", "TABLE Transaction Detail" },
                { "id", model.Id },

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
        public ActionResult C_GetEditDetailCuriculum(Curiculum model)
        {
            var dictionary = new Dictionary<string, object>
            {
                { "option", "GET Transaction Detail" },
                { "idDetail", model.IdDetail },

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
        public ActionResult C_UpdateHeadCuriculum(Curiculum model)
        {
            var dictionary = new Dictionary<string, object>
            {
                { "option", "UPDATE Curiculum Head" },
                { "typelevel", model.TypeLevel },
                { "namelevel", model.LevelName },
                { "user", "Ilhas" },
                { "id", model.Id },
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

        }
        public ActionResult C_TableListTraining(Curiculum model)
        {
            var dictionary = new Dictionary<string, object>
            {
                { "option", "TABLE Training List" },
                

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
        public ActionResult C_TableGolonganKompetensi(Curiculum model)
        {
            var dictionary = new Dictionary<string, object>
            {
                { "typelevel", "Golongan"},
                { "option", "VIEW Golongan Kompetensi" },
                

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
        public ActionResult C_TableJabatanKompetensi(Curiculum model)
        {
            var dictionary = new Dictionary<string, object>
            {
                { "typelevel", "Jabatan"},
                { "option", "VIEW Golongan Kompetensi" },


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
        public ActionResult UploadFileToServer()
        {
            string path;
            //string URLAttachment;
            var file = Request.Files[0];
            var fileName = Path.GetFileName("Training_" + file.FileName);
            path = Path.Combine(Server.MapPath("~/UploadFile/"), fileName);

            file.SaveAs(path);

            // Generate nomor id baru, menggunakan te 
            //dynamic newId = JsonConvert.DeserializeObject(GenerateNewId());

            // Populate table temporary dengan file excel yang sudah di upload
            // Tabel di staging terlebih dahulu ke dalam tabel temp_overtime_upload

            //string nomor = newId[0].Nomor;

            PopulateTempSQL(path);
            

            // Cek file yang di upload pada folder
            if (System.IO.File.Exists(path))
            {
                // Hapus file template yang telah di upload
                // Untuk meminimalkan space pada server
                System.IO.File.Delete(path);
            };

            

            return Json("OK");
        }
        public void PopulateTempSQL(string path)
        {
            string sourceConstr = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=No;'", path);
            string conString = mySetting.ConnectionString;
            using (OleDbConnection con = new OleDbConnection(sourceConstr))
            {
                //string sqlQuery = "select * from [Sheet1$] where [Employee ID] is not NULL";

                string sqlQuery = @"SELECT F1 as [EmpName], 
                                    F2 as [JenisTraining], 
                                    F3 as [PlanTraining], 
                                    F4 as [ActualTraining], 
                                    F5 as [TrainingDate],
                                    1 as [Isactive]
                                    from [Sheet1$]";

                //"Select * from [" + "Sheet1" + "$A3:B6]";
                OleDbCommand dbCommand = new OleDbCommand(sqlQuery, con);

                con.Open();
                OleDbDataReader dr = dbCommand.ExecuteReader();
                SqlBulkCopy bulkCopy = new SqlBulkCopy(conString);
                bulkCopy.DestinationTableName = "T_TrainingList";
                bulkCopy.ColumnMappings.Add("[EmpName]", "EmpName");
                bulkCopy.ColumnMappings.Add("[JenisTraining]", "JenisTraining");
                bulkCopy.ColumnMappings.Add("[PlanTraining]", "PlanTraining");
                bulkCopy.ColumnMappings.Add("[ActualTraining]", "ActualTraining");
                bulkCopy.ColumnMappings.Add("[TrainingDate]", "TrainingDate");
                bulkCopy.ColumnMappings.Add("[Isactive]", "Isactive");
                bulkCopy.WriteToServer(dr);
                con.Close();
            }
        }
    }
}