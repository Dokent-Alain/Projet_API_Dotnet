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
    public class RolesController : ControllerBase
    {
        private RolesService Rs;
        private PresenceManagementContext _ctx;
        private Ilog not_log;

        public RolesController(Ilog logger, PresenceManagementContext _ctx)
        {
            this.not_log = logger;
            this._ctx = _ctx;
            this.Rs = new RolesService(this._ctx);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("Roles")]
        public List<Roles> Get()
        {
            this.not_log.Information("bonjour");
            return this.Rs.GetRoles();
        }
        ///<summary>
        /// Recuperation de données
        ///</summary>
        ///
        [HttpPost]
        [Route("addRoles")]
        public object CreateRoles([FromBody] object param)
        {
            return string.Format("Hello Kitty");
        }
        ///<summary>
        /// Recuperation de données
        ///</summary>
        ///
        [HttpPut]
        [Route("update roles")]
        public Roles UpdateRoles(Roles roles)
        {
            return UpdateRoles(roles);
        }
    }
}
