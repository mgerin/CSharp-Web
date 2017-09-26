using System;
using _04.ManyToManyRelation.Data;

namespace _04.ManyToManyRelation
{
    public class StartUp
    {
        public static void Main()
        {
            MyDbContext db = new MyDbContext();
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
        }
    }
}
