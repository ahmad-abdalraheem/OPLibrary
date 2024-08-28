using Domain.DTO;
using Domain.Entities;

namespace Domain.IRepo;

public interface ICommentRepo
{
	public GetCommentDto Add(Comment comment);
	
	public GetCommentDto Update(SaveCommentDto comment, string commentId);
	
	public GetCommentDto Delete(string commentId);
	
	public List<GetCommentDto> Get(string articleSlug, string userName);
	
	public Comment GetById(string articleSlug, string commentId);
}