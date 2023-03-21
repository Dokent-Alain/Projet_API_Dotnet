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
    public class SessionCourseController : ControllerBase
    {
        private SessionCourseService Rs;
        private PresenceManagementContext _ctx;
        private Ilog not_log;

        public SessionCourseController(Ilog logger, PresenceManagementContext _ctx)
        {
            this.not_log = logger;
            this._ctx = _ctx;
            this.Rs = new SessionCourseService(this._ctx);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("Semester")]
        public List<SessionCourse> GetSessionCourse()
        {
            this.not_log.Information("bonjour");
            return this.Rs.GetSessionCourse();
        }
        ///<summary>
        /// Recuperation de données
        ///</summary>
        ///
        [HttpPost]
        [Route("addSessionCourse")]
        public object CreateSessionCourse([FromBody] object param)
        {
            return string.Format("Hello Kitty");
        }
        ///<summary>
        /// Recuperation de données
        ///</summary>
        ///
        [HttpPut]
        [Route("update SessionCourse")]
        public SessionCourse UpdateSessionCourse(SessionCourse sessionCourse)
        {
            return UpdateSessionCourse(sessionCourse);
        }
    }
}
