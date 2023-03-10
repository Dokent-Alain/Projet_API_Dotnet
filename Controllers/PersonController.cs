using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;    
using PresenceManagement.Businesslogic.Services;
using PresenceManagement.Controllers.Log;
using PresenceManagement.DataAccess.DBContexts;
using PresenceManagement.DataAccess.Models;

namespace PresenceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private PersonService Ps;
        private PresenceManagementContext _ctx;
        private Ilog not_log;

        public PersonController(Ilog logger, PresenceManagementContext _ctx)
        {
            this.not_log = logger;
            this._ctx = _ctx;
            this.Ps = new PersonService(this._ctx);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("Person")]
        public List<Person> Get()
        {
            this.not_log.Information("bonjour");
            return this.Ps.GetPerson();
        }
        ///<summary>
        /// Recuperation de données
        ///</summary>
        ///
        [HttpPost]
        [Route("addPerson")]
        public object CreatePerson([FromBody] object param)
        {
            return string.Format("Hello Kitty");
        }
        ///<summary>
        /// Recuperation de données
        ///</summary>
        ///
        [HttpPut]
        [Route("update person")]
        public Person UpdatePerson(Person person)
        {
            return UpdatePerson(person);
        }
    }
}
