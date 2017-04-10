using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcomparableAufgabe
{
    class Program
    {

        List<House> houses = new List<House>();

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Init();
        }

        public void Init()
        {
            

            House h1 = new House();
            h1.Height = 200;

            House h2 = new House();
            h2.Height = 180;

            House h3 = new House();
            h3.Height = 220;

            houses.Add(h1);
            houses.Add(h2);
            houses.Add(h3);

            showHouses();
            houses.Sort();
            showHouses();

        }

        public void showHouses()
        {
            foreach (House item in houses)
            {
                Console.WriteLine(item.Height);
            }
        }

    }
}
