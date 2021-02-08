using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //inherits from the IEmployee interface
    public interface IManaged : IEmployee
    {
        //Theses are exclusive to the Employee and the Manager
        IEmployee Manager { get; set; }
        void AssignManager(IEmployee manager);
    }
}
