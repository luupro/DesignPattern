namespace DesignParttern.CreationalDP.Singleton
{
    class Application
    {
        public void Main()
        {
            Database foo = Database.GetInstance();
            foo.query("SELECT ...");
            //...
            Database bar = Database.GetInstance();
            bar.query("SELECT ...");
            // The variable `bar` will contain the same object as
            // the variable `foo`.
        }
    }
}
