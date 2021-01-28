using System;
using System.Collections.Generic;
using System.Text;

namespace IZBankingATMClassLibrary
{
    public static class AdminInfo
    {
        public static string AdminName { get; set; }
        public static string formMessage { get; set; }
    }

    public static class CustomerInfo
    {
        public static string CustomerID { get; set; }
        public static string Deposit = "deposit";
        public static string Withdraw = "withdraw";
        public static string CustomerName { get; set; }
        public static int counter { get; set; }
        public static string CustomerTransactions1 { get; set; }
        public static string CustomerTransactions2 { get; set; }
        public static string CustomerTransactions3 { get; set; }
    }
}
