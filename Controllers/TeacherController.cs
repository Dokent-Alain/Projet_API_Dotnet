﻿using Microsoft.AspNetCore.Authorization;
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
    public class TeacherController : ControllerBase
    {
        private TeacherService Ts;
        private PresenceManagementContext _ctx;
        private Ilog not_log;

        public TeacherController(Ilog logger, PresenceManagementContext _ctx)
        {
            this.not_log = logger;
            this._ctx = _ctx;
            this.Ts = new TeacherService(this._ctx);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("Teacher")]
        public List<Teacher> GetTeacher()
        {
            this.not_log.Information("bonjour");
            return this.Ts.GetTeacher();
        }
        ///<summary>
        /// Recuperation de données
        ///</summary>
        ///
        [HttpPost]
        [Route("addTeacher")]
        public object CreateTeacher([FromBody] object param)
        {
            return string.Format("Hello Kitty");
        }
        ///<summary>
        /// Recuperation de données
        ///</summary>
        ///
        [HttpPut]
        [Route("update Teacher")]
        public Roles UpdateTeacher(Teacher teacher)
        {
            return UpdateTeacher(teacher);
        }
    }
}
