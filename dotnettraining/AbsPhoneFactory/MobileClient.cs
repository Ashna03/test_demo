using System;
using System.Collections.Generic;
using System.Text;

namespace AbsPhoneFactory
{
    //similar to web application,shop from where u are looking for product
    public class MobileClient
    {
        Phone applePhone;
        string Name;
        public MobileClient(IAppleFranchise shop, string name)
        {
            applePhone = shop.GetPhone(name);
        }

        public string GetPhoneDetails()
        {
            return applePhone.GetDetails();
        }
    }
}
