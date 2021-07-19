using AnimalShelterApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelterApi.Controllers
{
	// Version 1: Only GetAll
	[ApiVersion("1.0")]
	[Route("v{version:apiVersion}/animals")]
	[ApiController]
	public class AnimalShelterV1Controller : ControllerBase
	{
		private AnimalShelterApiContext _db;

		public AnimalShelterV1Controller(AnimalShelterApiContext db)
		{
			_db = db;
		}

		// GET /animals
		[HttpGet]
		public ActionResult<IEnumerable<Animal>> Get(int id, string name, string species, string gender, int age)
		{
			var query = _db.Animals.AsQueryable();

			if (id > 0)
			{
				query = query.Where(entry => entry.AnimalId == id);
			}

			if (name != null)
			{
				query = query.Where(entry => entry.Name == name);
			}

			if (species != null)
			{
				query = query.Where(entry => entry.Species == species);
			}

			if (gender != null)
			{
				query = query.Where(entry => entry.Gender == gender);
			}

			if (age > 0)
			{
				query = query.Where(entry => entry.Age == age);
			}

			return query.ToList();
		}
	}

	// Version 2: GetAll, Get
	[ApiVersion("2.0")]
	[Route("v{version:apiVersion}/animals")]
	[ApiController]
	public class AnimalShelterV2Controller : ControllerBase
	{
		private AnimalShelterApiContext _db;

		public AnimalShelterV2Controller(AnimalShelterApiContext db)
		{
			_db = db;
		}

		// GET /animals
		[HttpGet]
		public ActionResult<IEnumerable<Animal>> Get(int id, string name, string species, string gender, int age)
		{
			var query = _db.Animals.AsQueryable();

			if (id > 0)
			{
				query = query.Where(entry => entry.AnimalId == id);
			}

			if (name != null)
			{
				query = query.Where(entry => entry.Name == name);
			}

			if (species != null)
			{
				query = query.Where(entry => entry.Species == species);
			}

			if (gender != null)
			{
				query = query.Where(entry => entry.Gender == gender);
			}

			if (age > 0)
			{
				query = query.Where(entry => entry.Age == age);
			}

			return query.ToList();
		}

		// GET animals/{id}
		[HttpGet("{id}")]
		public ActionResult<Animal> Get(int id)
		{
			return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
		}
	}

	// Version 3: GetAll, Get, Post
	[ApiVersion("3.0")]
	[Route("v{version:apiVersion}/animals")]
	[ApiController]
	public class AnimalShelterV3Controller : ControllerBase
	{
		private AnimalShelterApiContext _db;

		public AnimalShelterV3Controller(AnimalShelterApiContext db)
		{
			_db = db;
		}

		// GET /animals
		[HttpGet]
		public ActionResult<IEnumerable<Animal>> Get(int id, string name, string species, string gender, int age)
		{
			var query = _db.Animals.AsQueryable();

			if (id > 0)
			{
				query = query.Where(entry => entry.AnimalId == id);
			}

			if (name != null)
			{
				query = query.Where(entry => entry.Name == name);
			}

			if (species != null)
			{
				query = query.Where(entry => entry.Species == species);
			}

			if (gender != null)
			{
				query = query.Where(entry => entry.Gender == gender);
			}

			if (age > 0)
			{
				query = query.Where(entry => entry.Age == age);
			}

			return query.ToList();
		}

		// GET animals/{id}
		[HttpGet("{id}")]
		public ActionResult<Animal> Get(int id)
		{
			return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
		}

		// POST animals
		[HttpPost]
		public void Post([FromBody] Animal animal)
		{
			_db.Animals.Add(animal);
			_db.SaveChanges();
		}
	}

	// Version 4: GetAll, Get, Post, Put
	[ApiVersion("4.0")]
	[Route("v{version:apiVersion}/animals")]
	[ApiController]
	public class AnimalShelterV4Controller : ControllerBase
	{
		private AnimalShelterApiContext _db;

		public AnimalShelterV4Controller(AnimalShelterApiContext db)
		{
			_db = db;
		}

		// GET /animals
		[HttpGet]
		public ActionResult<IEnumerable<Animal>> Get(int id, string name, string species, string gender, int age)
		{
			var query = _db.Animals.AsQueryable();

			if (id > 0)
			{
				query = query.Where(entry => entry.AnimalId == id);
			}

			if (name != null)
			{
				query = query.Where(entry => entry.Name == name);
			}

			if (species != null)
			{
				query = query.Where(entry => entry.Species == species);
			}

			if (gender != null)
			{
				query = query.Where(entry => entry.Gender == gender);
			}

			if (age > 0)
			{
				query = query.Where(entry => entry.Age == age);
			}

			return query.ToList();
		}

		// GET animals/{id}
		[HttpGet("{id}")]
		public ActionResult<Animal> Get(int id)
		{
			return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
		}

		// POST animals
		[HttpPost]
		public void Post([FromBody] Animal animal)
		{
			_db.Animals.Add(animal);
			_db.SaveChanges();
		}

		// PUT animals/{id}
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] Animal animal)
		{
			animal.AnimalId = id;
			_db.Entry(animal).State = EntityState.Modified;
			_db.SaveChanges();
		}
	}

	// Version 5: GetAll, Get, Post, Put, Delete
	[ApiVersion("5.0")]
	[Route("v{version:apiVersion}/animals")]
	[ApiController]
	public class AnimalShelterV5Controller : ControllerBase
	{
		private AnimalShelterApiContext _db;

		public AnimalShelterV5Controller(AnimalShelterApiContext db)
		{
			_db = db;
		}

		// GET /animals
		[HttpGet]
		public ActionResult<IEnumerable<Animal>> Get(int id, string name, string species, string gender, int age)
		{
			var query = _db.Animals.AsQueryable();

			if (id > 0)
			{
				query = query.Where(entry => entry.AnimalId == id);
			}

			if (name != null)
			{
				query = query.Where(entry => entry.Name == name);
			}

			if (species != null)
			{
				query = query.Where(entry => entry.Species == species);
			}

			if (gender != null)
			{
				query = query.Where(entry => entry.Gender == gender);
			}

			if (age > 0)
			{
				query = query.Where(entry => entry.Age == age);
			}

			return query.ToList();
		}

		// GET animals/{id}
		[HttpGet("{id}")]
		public ActionResult<Animal> Get(int id)
		{
			return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
		}

		// POST animals
		[HttpPost]
		public void Post([FromBody] Animal animal)
		{
			_db.Animals.Add(animal);
			_db.SaveChanges();
		}

		// PUT animals/{id}
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] Animal animal)
		{
			animal.AnimalId = id;
			_db.Entry(animal).State = EntityState.Modified;
			_db.SaveChanges();
		}

		// DELETE animals/{id}
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			Animal animal = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
			_db.Animals.Remove(animal);
			_db.SaveChanges();
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