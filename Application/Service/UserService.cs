using Domain.DTO;
using Domain.Entities;
using Domain.IRepo;

namespace Application.Service;

public class UserService(IUserRepo userRepo)
{
	public User Add(User newUser)
	{
		return userRepo.Add(newUser);
	}

	public User Update(User saveUser)
	{
		return userRepo.Update(saveUser);
	}

	public User Get(string username)
	{
		return userRepo.Get(username);
	}
	
	public bool CheckPassword(string username, string password)
	{
		return userRepo.Check(username, password);
	}

	public Author PromoteToAuthor(User user, string bio = "Hello, I am using OP blog!", string img = "user.png")
	{
		Author newAuthor = new Author
		{
			UserName = user.UserName,
			Email = user.Email,
			Password = user.Password,
			Bio = bio,
			Image = img,
			Followers = new List<User>(),
			FavoriteArticles = user.FavoriteArticles,
			Following = user.Following
		};
		return userRepo.PromoteToAuthor(newAuthor);
	}
}