using AbstractAndInterfaces.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractAndInterfaces.Concrete;
using AbstractAndInterfaces.Adapters;

namespace AbstractAndInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager=new SturbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer{Id=1,FirstName="Muzaffer Enes",LastName="Yapmaz",DateOfBirth=new DateTime(1997,1,25),NationalityId="25633943432"});
            Console.ReadKey();
        }
    }
}
