using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryProject
{
    /// <summary>
    /// Componente 
    /// </summary>
    abstract class MilitaryModel
    {
        
        int Id { get; set; }
        string Name { get; set; }
        int NumMed { get; set; }
        string Type { get; set; }
        DateTime AssistTime { get; set; }
    }
}
