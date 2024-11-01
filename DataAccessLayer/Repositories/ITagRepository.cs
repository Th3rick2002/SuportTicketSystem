using CommonLayer.Entities;

namespace DataAccessLayer.Repositories;

public interface ITagRepository
{
    public List<Tag> GetAllTags();
    public void addTag(Tag tag);
    void UpdateTags(Tag tag);
    void DeleteTags(int id);
}