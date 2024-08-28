using Domain.Entities;

namespace Domain.DTO
{
	public class GetCommentDto(Author author, User user)
	{
		public required string Id { get; init; } = Guid.NewGuid().ToString();

		public required string Body { get; set; }
	
		public required CommentAuthor Author { get; init; } = new CommentAuthor(author, user);
		
		public DateOnly CreatedAt { get; set; }
	
		public DateOnly UpdatedAt { get; set; }
	}

	public class CommentAuthor(Author author, User user)
	{
		public string UserName { get; init; } = author.UserName;

		public string? Bio { get; set; } = author.Bio;

		public string? Image { get; set; } = author.Image;

		public bool Following { get; set; } = author.Followers.Contains(user);
	}
}