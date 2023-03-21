﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PresenceManagement.Businesslogic.Services;
using PresenceManagement.Controllers.Log;
using PresenceManagement.DataAccess.DBContexts;
using PresenceManagement.DataAccess.Models;

namespace PresenceManagement.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private UsersService Uss;
        private PresenceManagementContext _ctx;
        private Ilog not_log;

        public UsersController(Ilog logger, PresenceManagementContext _ctx)
        {
            this.not_log = logger;
            this._ctx = _ctx;
            this.Uss = new UsersService(this._ctx);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("Semester")]
        public List<Users> GetUsers()
        {
            this.not_log.Information("bonjour");
            return this.Uss.GetUsers();
        }
        ///<summary>
        /// Recuperation de données
        ///</summary>
        ///
        [HttpPost]
        [Route("addSemester")]
        public object CreateUsers([FromBody] object param)
        {
            return string.Format("Hello Kitty");
        }
        ///<summary>
        /// Recuperation de données
        ///</summary>
        ///
        [HttpPut]
        [Route("update semester")]
        public Users UpdateUsers(Users users)
        {
            return UpdateUsers(users);
        }
    }
}