using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Comment
{
	[Key]
	public string Id { get; init; } = Guid.NewGuid().ToString();

	public required string Body { get; set; }
    
	public required Author Author { get; set; }
	
	public Article Article { get; set; } = null!;
    
	public DateOnly CreatedAt { get; init; }
    
	public DateOnly? UpdatedAt { get; set; }
}