﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace AngularProjeto2.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AngularProjeto2ControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}