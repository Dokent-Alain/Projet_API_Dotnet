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
    public class StudentsController : ControllerBase
    {
        [Route("api/[controller]")]
        [ApiController]
        public class StudentsControllers : ControllerBase
        {
            private StudentsService Ss;
            private PresenceManagementContext _ctx;
            private Ilog not_log;

            public StudentsService Ss1 { get => Ss; set => Ss = value; }
            public StudentsControllers(Ilog logger, PresenceManagementContext _ctx)
            {
                this.not_log = logger;
                this._ctx = _ctx;
                this.Ss = new StudentsService(this._ctx);
            }
            [HttpGet]
            [AllowAnonymous]
            [Route("Students")]
            public List<Students> GetStudent()
            {
                this.not_log.Information("bonjour");
                return this.Ss.GetStudent();
            }
            ///<summary>
            /// Recuperation de données
            ///</summary>
            ///
            [HttpPost]
            [Route("addStudents")]
            public object CreateStudents([FromBody] object param)
            {
                return string.Format("Hello Kitty");
            }
            ///<summary>
            /// Recuperation de données
            ///</summary>
            ///
            [HttpPut]
            [Route("update Students")]
            public Students UpdateStudents(Students students)
            {
                return UpdateStudents(students);
            }
        }
    }
}
