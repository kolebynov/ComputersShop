using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ComputersShop.Web.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CatalogController : ControllerBase
	{
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{
			return new string[] { "value1", "value2" };
		}

		[HttpGet("{id}")]
		public ActionResult<string> Get(int id)
		{
			return "value";
		}
	}
}
