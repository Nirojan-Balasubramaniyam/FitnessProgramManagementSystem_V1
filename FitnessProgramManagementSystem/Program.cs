using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FitnessProgram FitnessProgram1 = new FitnessProgram("FIT_001", "YOGA", "3 months", "10");
            /* Console.WriteLine(FitnessProgram1.ToString());
             Console.ReadLine();*/

            FitnessProgramManager manager = new FitnessProgramManager();

            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("FitnessProgram Management System: ");
                Console.WriteLine("1. Add a FitnessProgram");
                Console.WriteLine("2. View All FitnessPrograms");
                Console.WriteLine("3. Update a FitnessProgram");
                Console.WriteLine("4. Delete a FitnessProgram");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option:");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        CreateFitnessProgram(manager);
                        break;

                    case "2":
                        Console.Clear();
                        manager.ReadFitnessPrograms();
                        break;

                    case "3":
                        Console.Clear();
                        UpdateFitnessProgram(manager);
                        break;

                    case "4":
                        Console.Clear();
                        DeleteFitnessProgram(manager);
                        break;

                    case "5":
                        Console.Clear();
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input!!. Please select avalid input");
                        break;

                }

                if (!exit)
                {
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }
            }
        }

        static void CreateFitnessProgram(FitnessProgramManager manager)
        {
            Console.WriteLine("Enter FitnessProgram ID: ");
            string programId = Console.ReadLine();

            Console.WriteLine("Enter FitnessProgram Title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Enter FitnessProgram Duration: ");
            string duration = Console.ReadLine();

            Console.WriteLine("Enter FitnessProgram Price: ");
            string price = Console.ReadLine();

            manager.CreateFitnessProgram(programId, title, duration, price);
        }

        static void UpdateFitnessProgram(FitnessProgramManager manager)
        {
            Console.WriteLine("Enter FitnessProgram ID: ");
            string programId = Console.ReadLine();

            var program = manager.GetProgramByID(programId);
            if (program != null)
            {
                Console.WriteLine("Enter FitnessProgram Title: ");
                string title = Console.ReadLine();

                Console.WriteLine("Enter FitnessProgram Duration: ");
                string duration = Console.ReadLine();

                Console.WriteLine("Enter FitnessProgram Price: ");
                string price = Console.ReadLine();

                manager.UpdateFitnessProgram(programId, title, duration, price);
            }
            else
            {
                Console.WriteLine($"No Program available for ID: {programId}");
            }

        }

        static void DeleteFitnessProgram(FitnessProgramManager manager)
        {
            Console.WriteLine("Enter FitnessProgram ID: ");
            string programId = Console.ReadLine();

            manager.DeleteFitnessProgram(programId);
        }
    }
}
