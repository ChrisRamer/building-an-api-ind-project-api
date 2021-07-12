using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
	public class AnimalShelterApiContext : DbContext
	{
		public DbSet<Animal> Animals { get; set; }

		public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Animal>()
			.HasData(
				new Animal { AnimalId = 1, Name = "Luna", Species = "Cat", Gender = "Female", Age = 8 },
				new Animal { AnimalId = 2, Name = "Floofers", Species = "Cat", Gender = "Male", Age = 10 },
				new Animal { AnimalId = 3, Name = "Stella", Species = "Dog", Gender = "Female", Age = 19 },
				new Animal { AnimalId = 4, Name = "Katie", Species = "Dog", Gender = "Female", Age = 20 }
			);
		}
	}
}