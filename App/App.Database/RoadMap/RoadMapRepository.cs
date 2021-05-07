namespace App.Database.RoadMap
{
    public class RoadMapRepository : IRoadMapRepository
    {
        public readonly ApplicationContext _databaseContext;

        public RoadMapRepository(ApplicationContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
    }
}