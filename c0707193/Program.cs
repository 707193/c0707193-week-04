using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0707193
{
    class Program
    {
        static void Main(string[] args)
        {
            Countryside blue = new Countryside();
            blue.Launch();
        }
    }

    class Village
    {
        // node is an ADT
        // what kind of data do we need in a NODE?
        public Village nextvillage;
        public String VillageName;
        public Village previousVillage;
        public Village nextVillage;
        public bool isAstrildeHere = false;

    }
    class Countryside
    {

        Village Toronto = new Village();
        Village Maple = new Village();
        Village Ajex = new Village();
        Village First;
        Village last;
        Village Temp;


        public void Launch()
        {
           
            Village First = Toronto;
            Village last = Ajex;
            Toronto.VillageName = "Toronto";
            Toronto.nextVillage = Maple;
            Toronto.previousVillage = null;
            Maple.VillageName = "Maple";
            Maple.nextVillage = Ajex;
            Maple.previousVillage = Toronto;
            Ajex.VillageName = "Ajex";
            Ajex.nextVillage = null;
            Ajex.previousVillage = Maple;

            Console.WriteLine(this.dispalyMap());

        }
        public string dispalyMap()
        {
            string listofcities = "";
            // we need toprint all cities in the area

            while (true)
            {
                listofcities = listofcities + First.VillageName;
                Temp = First.nextVillage;
                listofcities = listofcities + Temp.VillageName;
            }
            return listofcities;

        }
    }
}
