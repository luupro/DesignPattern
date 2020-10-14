using System.ComponentModel;

namespace DesignParttern.CreationalDP.Singleton
{
    /// <summary>
    /// The Database class defines the `getInstance` method that lets
    /// clients access the same instance of a database connection
    /// throughout the program.
    /// </summary>
    class Database
    {
        // The field for storing the singleton instance should be
        // declare static.
        private static Database instance;

        /// <summary>
        /// The singleton's constructor should always be private to
        /// prevent direct construction calls with the `new`
        /// operator.
        /// </summary>
        private Database()
        { }

        // Some initialization code, such as the actual
        // connection to a database server.
        // ...

        // The static method that controls access to the singleton
        // instance.
        public static Database GetInstance()
        {
            if (Database.instance == null)
            {
                lock (instance)
                {
                    // Ensure that the instance hasn't yet been
                    // initialized by another thread while this one
                    // has been waiting for the lock's release
                    if (instance == null)
                    {
                        instance = new Database();
                    }
                }
            }

            return instance;
        }

        // Finally, any singleton should define some business logic
        // which can be executed on its instance.
        public void query(string sql)
        {
            // For instance, all database queries of an app go
            // through this method. Therefore, you can place
            // throttling or caching logic here.
            //...
        }
    }
}
