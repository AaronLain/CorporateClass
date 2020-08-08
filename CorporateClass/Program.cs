using CorporateClass.Corporate;
using System;

namespace CorporateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var ecorp = new Company("E-corp");

            ecorp.addEmployee("Angela Moss", "Junior Executive", DateTime.Now.AddDays(-92).AddYears(-3));
            ecorp.addEmployee("Tyrell Wellick", "Junior Executive", DateTime.Now.AddDays(-46).AddYears(-6));
            ecorp.addEmployee("Terry Colby", "CTO", DateTime.Now.AddDays(-2).AddYears(-12));
            ecorp.addEmployee("Phillip Price", "CEO", DateTime.Now.AddDays(-32).AddYears(-18));

            ecorp.getAllEmployees();

            ecorp.removeEmployee("Angela Moss");

            ecorp.getAllEmployees();
        }
    }
}
