using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeprToKeepr.Models;

namespace CheeprToKeepr.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CheeprToKeeprContext context)
        {
            context.Database.EnsureCreated();
            if (context.Users.Any()) //look for users
            {
                return; //DB has been seeded
            }
            var users = new User[]
            {
                new User{FirstName="TestUserFName",LastName="TestUserLName",AddressLine1="123 First St.",
                    AddressLine2="",City="CapitalCity",PostalCode="12345",State="US",Email="simpleuser@simpledomain.org"}
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            var vehicles = new Vehicle[]
            {
                new Vehicle{UserID=1,Year=2003,MakeName="Dodge",ModelName1="Neon",ModelName2="SRT-4",
                    VehicleMileage=12345,TireMileage=5000}
            };
            foreach(Vehicle v in vehicles)
            {
                context.Vehicles.Add(v);
            }
            context.SaveChanges();

            var services = new Service[]
            {
                new Service{VehicleID=1,ServicesCategoryID=1,ServiceName="Oil Change",ServiceDateTime=System.DateTime.Now,
                    VehicleMilesAtService=12000,VendorID=1}
            };
            foreach(Service s in services)
            {
                context.Services.Add(s);
            }
            context.SaveChanges();

            var vendors = new Vendor[]
            {
                new Vendor{Name="CheaperToKeeprAutoServiceChoice",City="Capital",State="US",PostalCode="12345",
                    PhoneNumber="8885551234",Email="vendor1@sampledomain.org",Website="NumberOneAutoServiceCo@somedomain.org",
                    VendorsCategoryID=1}
            };
            foreach(Vendor v in vendors)
            {
                context.Vendors.Add(v);
            }
            context.SaveChanges();

            var expenses = new Expense[]
            {
                new Expense{ExpenseCategoryID=1,Name="Vehicle Purchase",Details="Purchase from private owner. Paid with check from FirstBankUSA. Check No. ####",
                ExpenseDateTime=System.DateTime.Today,VehicleID=1,Cost=5000 }
            };
            foreach(Expense e in expenses)
            {
                context.Expenses.Add(e);
            }
            context.SaveChanges();
        }
    }
}
