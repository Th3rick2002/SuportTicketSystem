using CommonLayer.Entities;
using DataAccessLayer.Repositories;

namespace BussisnesLayer.Services.tagService;

public class tagService: ITagService
{
    private readonly TagRepository _tagRepository;

    public tagService()
    {
        _tagRepository = new TagRepository();
    }
    
    public List<Tag> GetAllTags()
    {
        return _tagRepository.GetAllTags();
    }

    public void addTag(Tag tag)
    {
        _tagRepository.addTag(tag);
    }

    public void UpdateTags(Tag tag)
    {
        _tagRepository.UpdateTags(tag);
    }

    public void DeleteTags(int id)
    {
        _tagRepository.DeleteTags(id);
    }
}