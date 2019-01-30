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
        }
    }

    class Village
    {
        // node is an ADT
        // what kind of data do we need in a NODE?
        public Village nextvillage;
        public String VillageName;
        public bool isAstrildeHere = false;

    }
    class Countryside
    {

        Village Toronto = new Village();
        Village Maple = new Village();
        Village Ajex = new Village();
        


            public void Launch()
        {
            Toronto.VillageName = "Toronto";
            Toronto.nextVillage = Maple;
            Toronto.previousVillage = null;
            Maple.VillageName = "Maple";
            Maple.nextVillage = Ajex;
            Maple.previousVillage = Toronto;
            Ajex.VillageName = "Ajex";
            Ajex.nextVillage = null;
            Ajex.previousVillage = Maple;
        }
    }
}
