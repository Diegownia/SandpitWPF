using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandpitWPF.Services
{
    public class ConversionsDataService : IConversionsDataService
    {
        private IList<string> Index { get; set; }

        public ConversionsDataService()
        {
            Index = new List<string>(); //{ "First", "Second", "Third"};
            PopList();
        }


        private void PopList()
        {
            Index.Add("First");
            Index.Add("Second");
            Index.Add("Third");
        }


        public IList<string> GetData()
        {
            return Index;
        }
    }
}
