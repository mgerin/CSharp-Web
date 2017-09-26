using System;
using _03.SelfReferencedTable.Data;

namespace _03.SelfReferencedTable
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
