using AbstractAndInterfaces.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaces.Concrete
{
    public class SturbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService checkService;
        public SturbucksCustomerManager(ICustomerCheckService _checkService)
        {
            checkService = _checkService;
        }
        public override void Save(Customer customer)
        {
            if (checkService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid Person");
            }
        }


    }
}
