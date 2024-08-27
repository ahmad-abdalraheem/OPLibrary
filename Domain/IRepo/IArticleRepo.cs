using Domain.DTO.Article;
using Domain.Entities;

namespace Domain.IRepo;

public interface IArticleRepo
{
	public GetArticleDto Add(Article newArticle);
	
	public GetArticleDto Update(Article article, Author author);
	
	public GetArticleDto Delete(string slug);
	
	public List<GetArticleDto> Get(string slug);
	
	public List<GetArticleDto> Search(SearchArticleDto searchArticleDto);
	
	public void UpdateTags(List<string>? tags);
}