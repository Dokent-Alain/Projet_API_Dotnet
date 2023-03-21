
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
    public class AdministController : ControllerBase
    {
        private AdministService Ad;
        private PresenceManagementContext _ctx;
        private Ilog not_log;

        public AdministService Ad1 { get => Ad; set => Ad = value; }

        public AdministController(Ilog logger, PresenceManagementContext _ctx)
        {
            this.not_log = logger;
            this._ctx = _ctx;
            this.Ad1 = new AdministService(this._ctx);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("Administ")]
        public List<Administ> GetAdminist()
        {
            this.not_log.Information("bonjour");
            return this.Ad1.GetAdminist();
        }
        ///<summary>
        /// Recuperation de données
        ///</summary>
        ///
        [HttpPost]
        [Route("addAdmin")]
        public object CreateAdminist([FromBody] object param)
        {
            return string.Format("Hello Kitty");
        }
        ///<summary>
        /// Recuperation de données
        ///</summary>
        ///
        [HttpPut]
        [Route("update Administ")]
        public Administ UpdateAdminist(Administ administ)
        {
            return UpdateAdminist(administ);
        }
    }

}
