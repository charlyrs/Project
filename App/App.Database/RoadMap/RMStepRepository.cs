namespace App.Database.RoadMap
{
    public class RMStepRepository : IRMStepRepository
    {
        private readonly ApplicationContext _databaseContext;

        public RMStepRepository(ApplicationContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
    }
}