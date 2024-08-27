using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Comment
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public required string Id { get; set; }
	
	public required string Body { get; set; }
	
	public required Author Author { get; set; }
	
	public DateOnly CreatedAt { get; set; }
	
	public DateOnly UpdatedAt { get; set; }
}