using Domain.DTO.Article;
using Domain.Entities;

namespace Domain.IRepo;

public interface IArticleRepo
{
	public GetArticleDto Add(Article newArticle);
	
	public GetArticleDto Update(SaveArticleDto article, User user);
	
	public GetArticleDto Delete(string slug, User user);
	
	public GetArticleDto Get(string slug);
	
	public List<GetArticleDto> Search(SearchArticleDto searchArticleDto);
	
	public void UpdateTags(List<Tag>? tags);
}