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
        public void CreateFitnessProgram(string type, string programId, string title, string duration, string price, string subscriptionType=null, bool needPersonalTrainer=false, string schedule=null, int groupCapacity=0)
        {
            if (type == "1")
            {
                FitnessProgram program = new IndividualFitnessProgram(programId, title, duration, price,  subscriptionType, needPersonalTrainer);
                fitnessProgramList.Add(program);
            }
            else
            {
                FitnessProgram program = new GroupFitnessProgram(programId, title, duration, price, schedule, groupCapacity);
                fitnessProgramList.Add(program);
            }
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
        public void DeleteFitnessProgram(string programId)
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

        public string ValidateFitnessProgramPrice()
        {
            decimal price =0;
            while (true)
            {
                Console.WriteLine("Enter FitnessProgram Price: ");
                if(decimal.TryParse(Console.ReadLine(), out price) && price>0)
                {
                   return price.ToString(); ;
                }

                Console.WriteLine("Invalid price!! please enter positive Number value");
            }
        }

    }
}
