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
	[Length(72,72)]
	public required string Password { get; set; }
}