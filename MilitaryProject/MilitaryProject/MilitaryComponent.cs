using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryProject
{
    /// <summary>
    /// Componente, donde se declaran todos los metodos que luego seran implementados en las Unidades
    /// </summary>
    public interface IMilitaryComponent
    {
        string getName();

        void setName(string nombre);

        string getDescription();

        void setDescription(string description);

        double getTimeAssist();

        void setTimeAssist(double Time);

        double getNumMed();

        void setNumMed(double numMed);

        double getAverage();
         
        void add(IMilitaryComponent component);

        void remove(IMilitaryComponent component);

        IMilitaryComponent getElement(int index);
    }
}
