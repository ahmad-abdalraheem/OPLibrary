using Domain.Entities;

namespace Domain.DTO.Article;

public class GetArticleDto
{
	public required string Slug { get; set; }
	
	public required string Title { get; set; }
	
	public required string Description { get; set; } 
	
	public required string Body { get; set; }
	
	public List<String>? Tags { get; set; }
	
	public DateOnly CreatedAt { get; set; }
	
	public DateOnly UpdatedAt { get; set; }
	
	public bool IsFavorite { get; set; }
	
	public int FavoriteCount { get; set; }
	
	public required Author Author { get; set; }
}