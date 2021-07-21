using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelterApi.Models
{
	public class ApiMethods
	{
		private AnimalShelterApiContext _db;

		public ApiMethods(AnimalShelterApiContext db)
		{
			_db = db;
		}

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

		public ActionResult<Animal> Get(int id)
		{
			return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
		}

		public void Post([FromBody] Animal animal)
		{
			_db.Animals.Add(animal);
			_db.SaveChanges();
		}

		public void Put(int id, [FromBody] Animal animal)
		{
			animal.AnimalId = id;
			_db.Entry(animal).State = EntityState.Modified;
			_db.SaveChanges();
		}

		public void Delete(int id)
		{
			Animal animal = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
			_db.Animals.Remove(animal);
			_db.SaveChanges();
		}
	}
}