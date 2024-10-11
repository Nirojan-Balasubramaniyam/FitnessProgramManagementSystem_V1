using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgram
    {
        private string fitnessProgramId { get; set; }
        private string title { get; set; }
        private string duration { get; set; }
        private string price { get; set; }
        public int TotalFitnessPrograms { get; private set; } = 1;

        public FitnessProgram(string fitnessProgramId, string title, string duration, string price)
        {
            this.fitnessProgramId = fitnessProgramId;
            this.title = title;
            this.duration = duration;
            this.price = price;
            TotalFitnessPrograms++;
        }

        public  override string ToString()
        {
            return $"fitnessProgramId: {fitnessProgramId}, Title: {title}, Duration: {duration}, Price: {price}"; 
        }
        public void SetId(string id)
        {
            this.fitnessProgramId = id;
        }

        public string GetId()
        {
            return this.fitnessProgramId;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public void SetDuration(string duration)
        {
            this.duration = duration;
        }

        public void SetPrice(string price)
        {
            this.price = price;
        }

        public virtual string DisplayFitnessProgramInfo()
        {
            //return this.ToString() ;
            return $"fitnessProgramId: {fitnessProgramId}, Title: {title}, Duration: {duration}, Price: {price}";
        }
    }


}
