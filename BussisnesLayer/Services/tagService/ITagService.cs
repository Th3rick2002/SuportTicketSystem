using CommonLayer.Entities;

namespace BussisnesLayer.Services.tagService;

public interface ITagService
{
    public List<Tag> GetAllTags();
    public void addTag(Tag tag);
    public void UpdateTags(Tag tag);
    public void DeleteTags(int id);
}