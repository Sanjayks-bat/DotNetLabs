using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpClassLib
{
    public interface IProjectRequirement
    {
        string GetUserStory();
        bool GetStoryStatus();
    }

    public class TaxTeam : IProjectRequirement
    {
        public bool GetStoryStatus()
        {
            return true;
        }

        public string GetUserStory()
        {
            return "Project Completed.";
        }
    }
}
