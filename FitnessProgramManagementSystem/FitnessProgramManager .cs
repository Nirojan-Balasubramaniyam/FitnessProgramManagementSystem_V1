using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgramManager
    {
        List<FitnessProgram> fitnessProgramList;

        public FitnessProgramManager()
        {
            this.fitnessProgramList = new List<FitnessProgram>();
        }
        public void CreateFitnessProgram(string programId, string title, string duration, string price)
        {
            fitnessProgramList.Add(new FitnessProgram(programId,title,duration,price));
            Console.WriteLine("FitnessProgram added successfully.");
        }

        public FitnessProgram GetProgramByID(string id)
        {
            var program = fitnessProgramList.Find(p=>p.GetId() == id);
            return program;
            
        }

        public void UpdateFitnessProgram(string programId, string title, string duration, string price)
        {
            var program = GetProgramByID(programId);
            if(program != null)
            {
                program.SetId(programId);
                program.SetTitle(title);
                program.SetDuration(duration);
                program.SetPrice(price);
                Console.WriteLine("FitnessProgram updated successfully.");
            }
            else
            {
                Console.WriteLine($"No Program available for ID: {programId}");
            }

        }
        public void DeleteFitnessProgram(string programId, string title, string duration, string price)
        {
            var program = GetProgramByID(programId);
            if (program != null)
            {
                fitnessProgramList.Remove(program);
                Console.WriteLine("FitnessProgram deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Delete failed!!. No Program available for ID: {programId}");
            }

        }

        public void ReadFitnessPrograms()
        {
            if (fitnessProgramList.Count()>0)
            {
                Console.WriteLine("FitnessPrograms List: ");
                foreach(var fitnessProgram in fitnessProgramList)
                {
                    Console.WriteLine(fitnessProgram.ToString());
                }
            }
            else
            {
                Console.WriteLine("No Programs available!!");
            }
        }

    }
}
