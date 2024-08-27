using Domain.Entities;

namespace Domain.IRepo;

public interface ICommentRepo
{
	public Comment Add(Comment comment);
	
	public Comment Update(Comment comment);
	
	public void Delete(Comment comment);
	
	public List<Comment> Get(int articleId);
	
	public Comment Get(int articleId, int commentId);
}