using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDPOnlineApps.Models
{
    public class IDPModel
    {
    }
    public class Curiculum
    {
        public int Id { get; set; }
        public int IdDetail { get; set; }
        public string TypeLevel { get; set; }
        public string LevelName { get; set; }
        public string User { get; set; }
        public string Judul { get; set; }
        public string Deskripsi { get; set; }
        public int Isactive { get; set; }
        public int Score { get; set; }
    }
}