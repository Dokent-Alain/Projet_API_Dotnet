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
    public class MattersController : ControllerBase
    {
        private MattersService Ps;
        private PresenceManagementContext _ctx;
        private Ilog not_log;

        public MattersController(Ilog logger, PresenceManagementContext _ctx)
        {
            this.not_log = logger;
            this._ctx = _ctx;
            this.Ps = new MattersService(this._ctx);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("Matters")]
        public List<Matters> GetMatters()
        {
            this.not_log.Information("bonjour");
            return this.Ps.GetMatters();
        }
        ///<summary>
        /// Recuperation de données
        ///</summary>
        ///
        [HttpPost]
        [Route("addMatters")]
        public object CreateMatters([FromBody] object param)
        {
            return string.Format("Hello Kitty");
        }
        ///<summary>
        /// Recuperation de données
        ///</summary>
        ///
        [HttpPut]
        [Route("update matters")]
        public Matters UpdateMatters(Matters matters)
        {
            return UpdateMatters(matters);
        }
    }
}
