using System;
using ExercicioInterfaces.Entities;
using System.Globalization;

namespace ExercicioInterfaces.Services
{
    class ContractService
    {
        public int InstallmentsQuantity { get; set; }
        public int InstallmentNumber { get; set; }

        private IFeeService _feeService;        

        public ContractService(int installmentsQuantity, int installmentNumber, IFeeService feeService)
        {
            InstallmentsQuantity = installmentsQuantity;
            InstallmentNumber = installmentNumber;
            _feeService = feeService;
        }

        public void ProcessContract(Contract contract)
        {
            double amount = contract.ContractValue / InstallmentsQuantity;
            double fee = _feeService.Fee(amount, InstallmentNumber);
            amount = (amount + fee) * 1.02;
            DateTime dueDate = contract.ContractDate.AddMonths(InstallmentNumber);
            contract.Installment = new Installment(dueDate, amount);
            
        }
    }
}
