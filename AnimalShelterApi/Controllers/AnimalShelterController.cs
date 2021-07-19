using AnimalShelterApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelterApi.Controllers
{
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
}