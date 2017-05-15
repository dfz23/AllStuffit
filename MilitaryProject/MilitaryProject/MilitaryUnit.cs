using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryProject
{
    internal class MilitaryUnit :IMilitaryComponent
    {
        private string name;
        private string description;
        private double time;
        private double numMed;
        private double AverageTime;

        public MilitaryUnit()
        {
        }

        #region Singleton

        private static IMilitaryComponent oInstance;

        internal static IMilitaryComponent Instance
        {
            get
            {
                if (oInstance == null)
                    oInstance = new MilitaryUnit();
                return oInstance;
            }
        }

        #endregion


        public MilitaryUnit(string name, string description, double time, double numMed)
        {
            this.name = name;
            this.description = description;
            this.time = time;
            this.numMed = numMed;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getDescription()
        {
            return description;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public double getTimeAssist()
        {
            return time;
        }

        public void setTimeAssist(double time)
        {
            this.time = time;
        }

        public double getNumMed()
        {
            return numMed;
        }

        public void setNumMed(double numMed)
        {
            this.numMed = numMed;
        }

        public double getAverage()
        {
            return AverageTime;
        }

        public void add(IMilitaryComponent componente)
        {
            throw new NotImplementedException();
        }

        public void remove(IMilitaryComponent componente)
        {
            throw new NotImplementedException();
        }

        public IMilitaryComponent getElement(int indice)
        {
            throw new NotImplementedException();
        }

        
    }
}
