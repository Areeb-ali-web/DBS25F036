using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace G_36_SmartPrint.BL
{
    internal class FinancialReportBL
    {
        public int Finance_id { get;set; }
        public ManagerBL Manager { get;set; }

        public DateTime Date { get;set; }
        public decimal totalRevinue {  get; set; }
        public decimal totalexpenses {  get; set; }
        public decimal totalprofit {  get; set; }
        
        public decimal CalculateTotal()
        {
            return totalRevinue- totalexpenses;
        }
        public FinancialReportBL(int finance_id, ManagerBL manager, DateTime date, decimal totalRevinue, decimal totalexpenses, decimal totalprofit)

        {
            Finance_id = finance_id;
            Manager = manager;
            Date = date;
            this.totalRevinue = totalRevinue;
            this.totalexpenses = totalexpenses;
            this.totalprofit = totalprofit;
        }
        public FinancialReportBL( ManagerBL manager, DateTime date, decimal totalRevinue, decimal totalexpenses, decimal totalprofit)

        {
            
            Manager = manager;
            Date = date;
            this.totalRevinue = totalRevinue;
            this.totalexpenses = totalexpenses;
            this.totalprofit = totalprofit;
        }
    }
}
