using System;
using _02.One_to_ManyRelation.Data;

namespace _02.One_to_ManyRelation
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
