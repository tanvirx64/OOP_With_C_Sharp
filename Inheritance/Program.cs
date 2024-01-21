namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //***** Inheritance *****
            //var text = new Text();
            //text.FontSize = 18;
            //text.FontWeight = 600;
            //text.Copy();
            //text.Duplicate();
            //text.AddHyperLink(@"http\\:www.google.com");

            //***** Composition *****
            var logger = new Logger();
            var migrator = new DbMigrator(logger);
            migrator.Migrate();

            var installer = new Installer(logger);
            installer.Install();
        }
    }
}
