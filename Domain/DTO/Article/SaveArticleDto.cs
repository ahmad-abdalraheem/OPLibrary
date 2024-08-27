namespace Domain.DTO.Article;

public class SaveArticleDto
{
	public required string Title { get; set; }

	public required string Description { get; set; } 

	public required string Body { get; set; }

	public List<String>? Tags { get; set; }
}