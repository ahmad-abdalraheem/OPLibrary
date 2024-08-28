using Domain.DTO;
using Domain.Entities;

namespace Domain.IRepo;

public interface IUserRepo
{
	public User Add(User user);
	
	public User Update(User user);
	
	public void Delete(string userName);
	
	public User Get(string userName);
	
	public bool Check(string email, string password);
	
	public Author PromoteToAuthor(Author author); 
}