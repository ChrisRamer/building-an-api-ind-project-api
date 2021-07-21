using AnimalShelterApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AnimalShelterApi.Controllers
{
	// Version 1: Only GetAll
	[ApiVersion("1.0")]
	[Route("v{version:apiVersion}/animals")]
	[ApiController]
	public class AnimalShelterV1Controller : ControllerBase
	{
		private AnimalShelterApiContext _db;
		private ApiMethods Methods;

		public AnimalShelterV1Controller(AnimalShelterApiContext db)
		{
			_db = db;
			Methods = new ApiMethods(db);
		}

		// GET /animals
		[HttpGet]
	 	public ActionResult<IEnumerable<Animal>> Get(int id, string name, string species, string gender, int age)
		{
			return Methods.Get(id, name, species, gender, age);
		}
	}

	// Version 2: GetAll, Get
	[ApiVersion("2.0")]
	[Route("v{version:apiVersion}/animals")]
	[ApiController]
	public class AnimalShelterV2Controller : ControllerBase
	{
		private ApiMethods Methods;

		public AnimalShelterV2Controller(AnimalShelterApiContext db)
		{
			Methods = new ApiMethods(db);
		}

		// GET /animals
		[HttpGet]
		public ActionResult<IEnumerable<Animal>> Get(int id, string name, string species, string gender, int age)
		{
			return Methods.Get(id, name, species, gender, age);
		}

		// GET animals/{id}
		[HttpGet("{id}")]
		public ActionResult<Animal> Get(int id)
		{
			return Methods.Get(id);
		}
	}


	// Version 3: GetAll, Get, Post
	[ApiVersion("3.0")]
	[Route("v{version:apiVersion}/animals")]
	[ApiController]
	public class AnimalShelterV3Controller : ControllerBase
	{
		private ApiMethods Methods;

		public AnimalShelterV3Controller(AnimalShelterApiContext db)
		{
			Methods = new ApiMethods(db);
		}

		// GET /animals
		[HttpGet]
		public ActionResult<IEnumerable<Animal>> Get(int id, string name, string species, string gender, int age)
		{
			return Methods.Get(id, name, species, gender, age);
		}

		// GET animals/{id}
		[HttpGet("{id}")]
		public ActionResult<Animal> Get(int id)
		{
			return Methods.Get(id);
		}

		// POST animals
		[HttpPost]
		public void Post([FromBody] Animal animal)
		{
			Methods.Post(animal);
		}
	}

	// Version 4: GetAll, Get, Post, Put
	[ApiVersion("4.0")]
	[Route("v{version:apiVersion}/animals")]
	[ApiController]
	public class AnimalShelterV4Controller : ControllerBase
	{
		private ApiMethods Methods;

		public AnimalShelterV4Controller(AnimalShelterApiContext db)
		{
			Methods = new ApiMethods(db);
		}

		// GET /animals
		[HttpGet]
		public ActionResult<IEnumerable<Animal>> Get(int id, string name, string species, string gender, int age)
		{
			return Methods.Get(id, name, species, gender, age);
		}

		// GET animals/{id}
		[HttpGet("{id}")]
		public ActionResult<Animal> Get(int id)
		{
			return Methods.Get(id);
		}

		// POST animals
		[HttpPost]
		public void Post([FromBody] Animal animal)
		{
			Methods.Post(animal);
		}

		// PUT animals/{id}
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] Animal animal)
		{
			Methods.Put(id, animal);
		}
	}

	// Version 5: GetAll, Get, Post, Put, Delete
	[ApiVersion("5.0")]
	[Route("v{version:apiVersion}/animals")]
	[ApiController]
	public class AnimalShelterV5Controller : ControllerBase
	{
		private ApiMethods Methods;

		public AnimalShelterV5Controller(AnimalShelterApiContext db)
		{
			Methods = new ApiMethods(db);
		}

		// GET /animals
		[HttpGet]
		public ActionResult<IEnumerable<Animal>> Get(int id, string name, string species, string gender, int age)
		{
			return Methods.Get(id, name, species, gender, age);
		}

		// GET animals/{id}
		[HttpGet("{id}")]
		public ActionResult<Animal> Get(int id)
		{
			return Methods.Get(id);
		}

		// POST animals
		[HttpPost]
		public void Post([FromBody] Animal animal)
		{
			Methods.Post(animal);
		}

		// PUT animals/{id}
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] Animal animal)
		{
			Methods.Put(id, animal);
		}

		// DELETE animals/{id}
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			Methods.Delete(id);
		}
	}

	// Version 6: Easter egg!
	[ApiVersion("6.0")]
	[Route("v{version:apiVersion}/animals")]
	[ApiController]
	public class AnimalShelterV6Controller : ControllerBase
	{
		private AnimalShelterApiContext _db;

		public AnimalShelterV6Controller(AnimalShelterApiContext db)
		{
			_db = db;
		}
	}
}