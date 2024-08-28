using Domain.IRepo;

namespace Application.Service;

public class TagService(ITagsRepo tagsRepo)
{
	public List<string> Get() => tagsRepo.Get();
}