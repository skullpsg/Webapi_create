using BlogWebApi.Entities;
using BlogWebApi.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity.Owin;
using System.Web;
using Microsoft.Owin;

namespace BlogWebApi.Controllers
{
    public class BaseApiController : ApiController
    {

        private ModelFactory _modelFactory;
        private ApplicationUserManager _AppUserManager = null;
        private readonly IOwinContext _iOwinContext = HttpContext.Current.GetOwinContext();

        protected ApplicationUserManager AppUserManager
        {
            get
            {
                return _AppUserManager ?? _iOwinContext.GetUserManager<ApplicationUserManager>();
            }
        }

        public BaseApiController()
        {
        }

        protected ModelFactory TheModelFactory
        {
            get
            {
                if (_modelFactory == null)
                {
                    _modelFactory = new ModelFactory(this.Request, this.AppUserManager);
                }
                return _modelFactory;
            }
        }

        protected IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }
    }
}