using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace KotAtGentAPI.Models {
    public partial class KotAtGent_Kot {
        /// <summary>
        /// Connection object db
        /// </summary>
        public static KotAtGentDataClassesDataContext db = new KotAtGentDataClassesDataContext();
        /// <summary>
        /// Get all "kot" infomation from database
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<KotAtGent_Kot> GetAllKotInfo() {
            var kots = (from kot in db.KotAtGent_Kots
                         orderby kot.Zone
                         select kot);
            return kots;
        }
        
        /// <summary>
        /// Get a record by the id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static KotAtGent_Kot GetKotInfoByID(int id) {
            var kot = db.KotAtGent_Kots.FirstOrDefault((k) => k.ID == id);
            if (kot == null) {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return kot;
        }

        /// <summary>
        /// Get a set of record which belongs to the certain type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IEnumerable<KotAtGent_Kot> GetKotInfoByTpye(string type) {
            return db.KotAtGent_Kots.Where(
                //(k) => string.Equals(k.Type, type,
                    //StringComparison.OrdinalIgnoreCase));
                    (k)=>k.Type==type);
        }
    }
}