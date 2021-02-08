using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //inherits from the IEmployee interface
    public interface IManager : IEmployee
    {
        //this is exclusive to the Manager and the CEO
        void GeneratePerformanceReview();
    }
}
