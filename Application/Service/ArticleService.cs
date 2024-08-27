using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using Domain.DTO.Article;
using Domain.Entities;
using Domain.IRepo;

namespace Application.Service;

public class ArticleService(IArticleRepo articleRepo)
{
	public GetArticleDto Add(SaveArticleDto saveArticleDto, Author author)
	{
		Article newArticle = new Article()
		{
			Id = 0,
			CreatedAt = DateOnly.FromDateTime(DateTime.Now),
			UpdatedAt = null,
			Slug = GenerateArticleSlug(saveArticleDto.Title),
			Title = saveArticleDto.Title,
			Description = saveArticleDto.Description,
			Body = saveArticleDto.Body,
			Tags = saveArticleDto.Tags,
			Favorites = new List<User>(),
			Author = author,
			Comments = new List<Comment>()
		}; // will be replaced with auto mapper

		if (saveArticleDto.Tags != null)
			articleRepo.UpdateTags(newArticle.Tags);
		return articleRepo.Add(newArticle);
	}

	public GetArticleDto Update(SaveArticleDto saveArticleDto)
	{
		
	}

	private string GenerateArticleSlug(string title)
	{
		string slug = title.ToLower().Replace(" ", "-").Replace(".", "dot").Replace("+", "plus");
		slug = Regex.Replace(slug, @"[^a-z0-9-]", "");
		slug += "--" + DateTime.Now.ToString("yyMMddhhmmss");

		return slug;
	}
}