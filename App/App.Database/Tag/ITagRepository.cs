using System.Collections.Generic;
using System.Threading.Tasks;
using App.Database.Models;

namespace App.Database.Tag
{
    public interface ITagRepository
    {
        public Task<int> AddTag(Models.Tag tag);
        public Task<bool> AddTagToTask(int tagId, int taskId);
        public Task<Models.Tag> GetTagByIdWithTasks(int id);
       
    }
}