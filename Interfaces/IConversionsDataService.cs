using System.Collections;
using System.Collections.Generic;

namespace SandpitWPF.Services
{
    public interface IConversionsDataService
    {
        //IList<string> Index { get; set; }

        //void PopList();

        IList<string> GetData();
    }
}