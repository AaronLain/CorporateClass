using CorporateClass.Corporate;
using System;

namespace CorporateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var ecorp = new Company("E-corp");

            ecorp.addEmployee("Angela Moss", "Junior Executive", DateTime.Now.AddYears(-3));

            ecorp.getAllEmployees();

            ecorp.removeEmployee("Angela Moss");

            ecorp.getAllEmployees();
        }
    }
}
