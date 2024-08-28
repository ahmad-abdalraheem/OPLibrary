using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Tag
{
	public Tag() { }

	public Tag(string tagName)
	{
		Name = tagName;
	}

	[Key]
	[MaxLength(25)]
	public required string Name { get; set; }
}
