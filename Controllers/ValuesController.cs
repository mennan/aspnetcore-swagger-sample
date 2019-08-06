using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Swagger.Sample.Controllers
{
	[Route("api/[controller]")]
	public class ValuesController : Controller
	{
		/// <summary>
		/// Get all values
		/// </summary>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		/// <summary>
		/// Get value by id
		/// </summary>
		/// <param name="id">Value id</param>
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		/// <summary>
		/// Create a new value
		/// </summary>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		/// <summary>
		/// Update value by id
		/// </summary>
		/// <param name="id">Value id</param>
		/// <param name="value">Value informations</param>
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		/// <summary>
		/// Delete a value by id
		/// </summary>
		/// <param name="id">Value id</param>
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
