using System;
using System.Linq;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MyContext())
            {
                var entity = new MyEntity { Name = "John" };
                db.MyEntities.Add(entity);
                db.SaveChanges();

                var entities = db.MyEntities.ToList();
                foreach (var e in entities)
                {
                    Console.WriteLine("{0} - {1}", e.Id, e.Name);
                }
            }

            Console.ReadKey();
        }
    }
}
