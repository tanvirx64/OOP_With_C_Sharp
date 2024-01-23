using System;

namespace Extensibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DbMigrator dbMigrator = new DbMigrator(new ConsoleLogger());
            //dbMigrator.Migrate();

            DbMigrator dbMigrator1 = new DbMigrator(new FileLogger(@"C:\\Users\\Tanvir\\Desktop\\log.txt"));
            dbMigrator1.Migrate();

        }
    }
}
