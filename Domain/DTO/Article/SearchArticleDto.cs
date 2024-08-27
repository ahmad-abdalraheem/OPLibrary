using Domain.Entities;

namespace Domain.DTO.Article;

public class SearchArticleDto
{
	public Author? Author { get; set; }
	
	public string? Tag { get; set; }
	
	public bool OnlyFavorites { get; set; }
}