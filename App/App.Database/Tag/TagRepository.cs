using System.Collections.Generic;
using System.Threading.Tasks;
using App.Database.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace App.Database.Tag
{
    public class TagRepository:ITagRepository
    {
        private readonly ApplicationContext _databaseContext;

        public TagRepository(ApplicationContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public  async Task<int> AddTag(Models.Tag tag)
        {
            var project = await _databaseContext.Projects.FindAsync(tag.Project.Id);
            var dbTag = new TagDB()
            {
                Project = project,
                Tasks = new List<ProjectTaskDB>(),
                Text = tag.Text
            };
            await _databaseContext.Tags.AddAsync(dbTag);
            await _databaseContext.SaveChangesAsync();
            return dbTag.Id;
        }

        public async Task<bool> AddTagToTask(int tagId, int taskId)
        {
            var tag = await _databaseContext.Tags.FindAsync(tagId);
            var task = await _databaseContext.Tasks.Include(t => t.Tags).FirstOrDefaultAsync(t => t.Id == taskId);
            task.Tags.Add(tag);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}