using Domain.Entities;

namespace Domain.IRepo;

public interface ITagsRepo
{
	public Tag Add(Tag tag);
	
	public Tag Update(Tag tag);
	
	public List<string> Get();
	
	public Tag Search(string tag);
}