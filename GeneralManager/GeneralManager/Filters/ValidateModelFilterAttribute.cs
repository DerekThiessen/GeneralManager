﻿using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace GeneralManager.Filters
{
	public class ValidateModelFilterAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuting(HttpActionContext actionContext)
		{
			if (actionContext.ModelState.IsValid)
				return;

			actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, actionContext.ModelState);
		}
	}
}