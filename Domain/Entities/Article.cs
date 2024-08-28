using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Article
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; set; }
	
	[DataType(DataType.Date)]
	public DateOnly CreatedAt { get; set; }
	
	[DataType(DataType.Date)]
	public DateOnly? UpdatedAt { get; set; }
	
	[MaxLength(100)]
	public required string Slug { get; set; }
	
	[MaxLength(100)]
	public required string Title { get; set; }
	
	[MaxLength(1_000)]
	public required string Description { get; set; } 
	
	[MaxLength(10_000)]
	public required string Body { get; set; }
	
	public List<Tag>? Tags { get; set; }
	
	public required List<User> Favorites { get; set; }
	
	public required Author Author { get; set; }
	
	public required List<Comment> Comments { get; set; }
}