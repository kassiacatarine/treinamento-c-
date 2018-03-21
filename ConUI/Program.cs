using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectModel;

namespace ConUI
{
    class Program
    {
        public static Project BusinessProject;
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            createProject();

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        //public void PrintProject(Project project)
        //{
        //}

        public static void createProject()
        {
            BusinessProject = new Project
            {
                Id = 1,
                Removed = false,
                Title = readLine("Digite o titulo do projeto: "),
                Comments = readLine("Digite algum coméntario sobre o projeto: "),
                Code = readLine("Digite o código do projeto: "),
                StartDate = DateTime.Now,
                EstimatedEndDate = DateTime.Parse(readLine("Digite a data de termino estimada: ")),
            };
        }

        public static string readLine(string mensage)
        {
            Console.WriteLine(mensage);
            return Console.ReadLine();
        }

        public bool FinishProject()
        {
            if(DateTime.Compare(BusinessProject.RealEndTime, DateTime.Now) >= 0)
            {
                return false;
            }
            return true;
        }

        public bool RemoveProject()
        {
            return BusinessProject.SetRemoved();
        }

    }
}
