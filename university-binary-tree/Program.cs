using System;

namespace university_binary_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.Name = "rector";
            rectorPosition.Salary = 1000;
            rectorPosition.Taxes = 15;

            Position vicFiPosition  = new Position();
            vicFiPosition.Name = "vicerector financiero";
            vicFiPosition.Salary = 750;
            vicFiPosition.Taxes = 10;

            Position contadorPosition = new Position();
            contadorPosition.Name = "contador";
            contadorPosition.Salary = 500;
            contadorPosition.Taxes = 5;

            Position jefiPosition = new Position();
            jefiPosition.Name = "jefe financiero";
            jefiPosition.Salary = 610;
            jefiPosition.Taxes =  5;

            Position secFin1Position = new Position();
            secFin1Position.Name = "secretaria financiera 1";
            secFin1Position.Salary = 350;
            secFin1Position.Taxes = 2;

            Position secFin2Position = new Position();
            secFin2Position.Name = "secretaria financiera 2";
            secFin2Position.Salary = 310;
            secFin2Position.Taxes = 2;

           Position vicAcdPosition = new Position();
            vicAcdPosition.Name = "vicerector academico";
            vicAcdPosition.Salary = 780;
            vicAcdPosition.Taxes = 15;

            Position jefRPosition = new Position();
            jefRPosition.Name = "jefe registro ";
            jefRPosition.Salary = 640;
            jefRPosition.Taxes = 5;

            Position secTr2Position = new Position();
            secTr2Position.Name = "secretaria academica 2";
            secTr2Position.Salary = 360;
            secTr2Position.Taxes = 2;

            Position secTr1Position = new Position();
            secTr1Position.Name = "secretaria academica 1";
            secTr1Position.Salary = 400;
            secTr1Position.Taxes = 2;

            Position asist1Position = new Position();
            asist1Position.Name = "asistente 1";
            asist1Position.Salary = 250;
            asist1Position.Taxes = 0;

            Position asist2Position = new Position();
            asist2Position.Name = "asistente 2";
            asist2Position.Salary = 170;
            asist1Position.Taxes = 0;

            Position mensjPosition = new Position();
            mensjPosition.Name = "mensajero";
            mensjPosition.Salary = 90;
            mensjPosition.Taxes = 0;




            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicFiPosition, rectorPosition.Name);
           universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFiPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
           universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);
             universityTree.CreatePosition(universityTree.Root, jefiPosition, vicFiPosition.Name);
            universityTree.CreatePosition(universityTree.Root, vicAcdPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefRPosition, vicAcdPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secTr2Position, jefRPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secTr1Position, jefRPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asist1Position, secTr1Position.Name);
            universityTree.CreatePosition(universityTree.Root, asist2Position, secTr1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensjPosition, asist2Position.Name);





           universityTree.PrintTree(universityTree.Root);

            float totalSalary = universityTree.Addsalaries(universityTree.Root);
            Console.WriteLine($"Total salaries: {totalSalary}");





            float SalaryAverage = universityTree.SalaryAverage();
            Console.WriteLine($"Salary Average: {SalaryAverage}");


           
            double TotalTaxes = universityTree.TotalTaxes(universityTree.Root);
            Console.WriteLine($"Total Taxes: {TotalTaxes}"); 



        }
    }
}
