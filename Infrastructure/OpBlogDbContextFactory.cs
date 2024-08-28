using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

public class OpBlogDbContextFactory : IDesignTimeDbContextFactory<OpBlogDbContext>
{
	public OpBlogDbContext CreateDbContext(string[] args)
	{
		var configuration = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.json")
			.Build();

		var optionsBuilder = new DbContextOptionsBuilder<OpBlogDbContext>();
		var connectionString = configuration.GetConnectionString("DefaultConnection");

		optionsBuilder.UseNpgsql(connectionString);

		return new OpBlogDbContext(optionsBuilder.Options);
	}
}