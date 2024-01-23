using System;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            this._logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration Started at : " + DateTime.Now);

            _logger.LogError($"An unknown error is occured  :  {DateTime.Now}");

            _logger.LogInfo("Migration Finished at : " + DateTime.Now);
        }
    }
}
