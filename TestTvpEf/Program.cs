using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TestTvpEf
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TestDb())
            {
                db.Configuration.ProxyCreationEnabled = false;

                var graphq = from p in db.Person
                             .Include(p => p.Country)
                             //.Include(p => p.Order)
                             select p;

              
                var items = graphq.ToArray();                

                Console.WriteLine("Ok");

                var t2 = from p in db.Database.SqlQuery<Person>("select * from ifn_get_persons2()")
                         join c in db.Country on p.CountryId equals c.Id
                         select new { p, c };

                var trace = t2.ToString();
                Console.WriteLine(trace);

                var res = t2.ToArray();

            }
        }
    }
}
