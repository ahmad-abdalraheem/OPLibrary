using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace Domain.Entities;

public class Author
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; set; }
	
	[Required]
	public required string UserName { get; set; }
	
	public string? Bio { get; set; }
	
	public string? Image { get; set; }
	
	public required List<User> Followers { get; set; }
}