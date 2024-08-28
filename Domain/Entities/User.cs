using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class User
{
	[Key]
	[MaxLength(50)]
	public required string UserName { get; set; }
	
	[Required]
	[EmailAddress]
	public required string? Email { get; set; }
	
	[Required]
	[MaxLength(72)]
	public required string Password { get; set; }
	
	public required List<Article> FavoriteArticles { get; set; } = new();

	public required List<Author> Following { get; set; } = new();
}