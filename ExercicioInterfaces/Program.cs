using System;
using System.Globalization;
using ExercicioInterfaces.Entities;
using ExercicioInterfaces.Services;
using System.Collections.Generic;

namespace ExercicioInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contract> list = new List<Contract>();
            Console.WriteLine("Enter contract data.");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installmentsNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= installmentsNumber; i++)
            {
                Contract contract = new Contract(contractNumber, contractDate, contractValue);
                int number = i;
                ContractService contractService = new ContractService(installmentsNumber, number, new FeeService());
                contractService.ProcessContract(contract);
                
                list.Add(contract);
            }

            Console.WriteLine("Installments: ");
            foreach (Contract x in list)
            {
                Console.WriteLine(x);
            }
        }
    }
}
