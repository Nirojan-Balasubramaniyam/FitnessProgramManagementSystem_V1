using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class GroupFitnessProgram : FitnessProgram
    {
        public string Schedule {  get; set; }
        public int GroupCapacity { get; set; }

        public GroupFitnessProgram(string fitnessProgramId, string title, string duration, string price, string schedule, int groupCapacity) : base(fitnessProgramId, title, duration, price)
        {
            Schedule = schedule;
            GroupCapacity = groupCapacity;
        }

        /*public string DisplayGroupFitnessProgramInfo()
        {
            return base.ToString() + $"Schedule: {Schedule}, GroupCapacity: {GroupCapacity}";
        }*/

        public override string DisplayFitnessProgramInfo()
        {
            return base.DisplayFitnessProgramInfo() + $"Schedule: {Schedule}, GroupCapacity: {GroupCapacity}";
        }
    }
}
