using System;
using System.Globalization;

namespace ExercicioInterfaces.Entities
{
    class Contract
    {   
        public int Number { get; set; }
        public DateTime ContractDate { get; set; }
        public double ContractValue { get; set; }
        public Installment Installment { get; set; }

        public Contract(int number, DateTime contractDate, double contractValue)
        {
            Number = number;
            ContractDate = contractDate;
            ContractValue = contractValue;
        }

        public override string ToString()
        {
            return Installment.DueDate + " - " + Installment.Amount;
        }

    }
}
