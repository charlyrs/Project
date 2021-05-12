using System.Threading.Tasks;

namespace App.Database.Tag
{
    public interface ITagRepository
    {
        public Task<int> AddTag(Models.Tag tag);
        public Task<bool> AddTagToTask(int tagId, int taskId);
        public Task<Models.Tag> GetTagByIdWithTasks(int id);
    }
}