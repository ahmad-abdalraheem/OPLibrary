using Domain.DTO;
using Domain.Entities;
using Domain.IRepo;

namespace Application.Service;

public class CommentsService(ICommentRepo commentRepo)
{
	public GetCommentDto Add(SaveCommentDto comment, Author author, Article article)
	{
		Comment newComment = new Comment
		{
			Body = comment.Body,
			Author = author,
			Article = article,
			CreatedAt = DateOnly.FromDateTime(DateTime.Now),
			UpdatedAt = null
		};
		return commentRepo.Add(newComment);
	}

	public GetCommentDto Update(SaveCommentDto comment, string commentId)
	{
		return commentRepo.Update(comment, commentId);
	}

	public GetCommentDto Delete(string commentId)
	{
		return commentRepo.Delete(commentId);
	}

	public List<GetCommentDto> GetComments(string articleSlug, string userName)
	{
		return commentRepo.Get(articleSlug, userName);
	}

}