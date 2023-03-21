using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PresenceManagement.Businesslogic.Services;
using PresenceManagement.Controllers.Log;
using PresenceManagement.DataAccess.DBContexts;
using PresenceManagement.DataAccess.Models;

namespace PresenceManagement.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SemesterController : ControllerBase
    {
        private SemesterService Rs;
        private PresenceManagementContext _ctx;
        private Ilog not_log;

        public SemesterController(Ilog logger, PresenceManagementContext _ctx)
        {
            this.not_log = logger;
            this._ctx = _ctx;
            this.Rs = new SemesterService(this._ctx);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("Semester")]
        public List<Semester> GetSemester()
        {
            this.not_log.Information("bonjour");
            return this.Rs.GetSemester();
        }
        ///<summary>
        /// Recuperation de données
        ///</summary>
        ///
        [HttpPost]
        [Route("addSemester")]
        public object CreateSemester([FromBody] object param)
        {
            return string.Format("Hello Kitty");
        }
        ///<summary>
        /// Recuperation de données
        ///</summary>
        ///
        [HttpPut]
        [Route("update semester")]
        public Roles UpdateSemester(Semester semester)
        {
            return UpdateSemester(semester);
        }
    }
}
