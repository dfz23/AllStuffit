using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IMilitaryComponent med1 = new MilitaryUnit("Medical Unit 1", "Medical Unit for North", 600, 3);
            IMilitaryComponent med2 = new MilitaryUnit("Medical Unit 2", "Medical Unit for South", 300, 5);
            IMilitaryComponent med3 = new MilitaryUnit("Medical Unit 3", "Medical Unit for West", 1200, 7);
            IMilitaryComponent med4 = new MilitaryUnit("Medical Unit 4", "Medical Unit for East", 1000, 8);

            IMilitaryComponent UnitCauca = new Unit("Unit Cauca", "Unit for Cauca Dept", 3000, 50);

            UnitCauca.add(med1);
            UnitCauca.add(med2);
            UnitCauca.add(med3);
            UnitCauca.add(med4);

            IMilitaryComponent AdminUnit = new MilitaryUnit("Admin Unit 1","Administrator 1",0,0);

            IMilitaryComponent ColombiaUnit = new Unit("General Unit", "Unit for Colombia", 0, 0);

            ColombiaUnit.add(UnitCauca);
            ColombiaUnit.add(AdminUnit);

            Console.WriteLine(ColombiaUnit.getName()+'\n');

            double TotalTime = ColombiaUnit.getTimeAssist();

            Console.WriteLine("Total Time Unit for Colombia: " + TotalTime);

            Console.WriteLine("Average Time for Unit: " + ColombiaUnit.getAverage());

            double TotalMed = ColombiaUnit.getNumMed();

            Console.WriteLine("Total Doctors for Unit Colombia: "+ TotalMed);

            Console.ReadLine();

        }        
    }
}
