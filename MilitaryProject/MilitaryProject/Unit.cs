using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryProject
{
    internal class Unit : IMilitaryComponent
    {
        #region Singleton

        private static IMilitaryComponent oInstance;

        internal static IMilitaryComponent Instance
        {
            get
            {
                if (oInstance == null)
                    oInstance = new Unit();
                return oInstance;
            }
        }

        #endregion


        private List<IMilitaryComponent> UnitList;

        private string name;
        private string desccription;
        private double AssisTime;
        private double NumMed;
        private double AverageTime;
        public Unit()
        {

        }
        public Unit(string name, string description, double AssisTime, double NumMed)
        {
            UnitList = new List<IMilitaryComponent>();

            this.name = name;
            this.desccription = description;
            this.AssisTime = AssisTime;
            this.NumMed = NumMed;
        }

        

        public void add(IMilitaryComponent component)
        {
            UnitList.Add(component);
        }

        public void remove(IMilitaryComponent component)
        {
            UnitList.Remove(component);
        }
        public IMilitaryComponent getElement(int index)
        {
            return (IMilitaryComponent)UnitList[index];
        }

        public string getName()
        {
            string FullName = this.name + '\n';

            UnitList.All(x =>
            {
                FullName += x.getName();
                return true;
            });

            return FullName;
        }

        public string getDescription()
        {
            string FullDesc = this.desccription + '\n';

            UnitList.All(x =>
            {
                FullDesc += x.getDescription();
                return true;
            });

            return FullDesc;
        }

        public double getTimeAssist()
        {
            double TotalTime = this.AssisTime;

            UnitList.All(x =>
            {
                TotalTime += x.getTimeAssist();
                return true;
            });

            return TotalTime;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setDescription(string description)
        {
            this.desccription = description;
        }

        public void setTimeAssist(double assisTime)
        {
            this.AssisTime = assisTime;
        }

        public double getNumMed()
        {
            double TotalMed = this.NumMed;

            UnitList.All(x =>
            {
                TotalMed += x.getNumMed();
                return true;
            });

            return TotalMed;
        }

        public void setNumMed(double numMed)
        {
            this.NumMed = numMed;
        }

        public double getAverage()
        {
            double TotalAvg = this.AssisTime;
            UnitList.All(x =>
            {
                TotalAvg += x.getAverage()/UnitList.Count;
                return true;
            });
            return TotalAvg;
        }

        

        
    }
}
