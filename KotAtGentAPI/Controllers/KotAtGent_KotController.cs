using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using System.Web.Mvc;
using KotAtGentAPI.Models;

namespace KotAtGentAPI.Controllers
{
    public class KotAtGent_KotController : ApiController
    {
        
        /// <summary>
        /// Get all records.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<KotAtGent_Kot> GetAllKotAtGent_Kot() {
            return KotAtGent_Kot.GetAllKotInfo();
        }

        public KotAtGent_Kot GetKotAtGent_KotById(int id) {
            return KotAtGent_Kot.GetKotInfoByID(id);
        }

        public IEnumerable<KotAtGent_Kot> GetKotAtGent_KotByType(string type) {
            return KotAtGent_Kot.GetKotInfoByTpye(type);
        }
    }
}
