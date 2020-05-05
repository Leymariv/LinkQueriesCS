using System;

namespace LinqWinformProject.LinkStart.Model
{
    public static class DatabaseFactory
    {
        private static Func<EntitiesDb> database = () => new EntitiesDb();

        public static Func<EntitiesDb> Database
        {
            get { return database; }
            set { database = value; }
        }
    }
}