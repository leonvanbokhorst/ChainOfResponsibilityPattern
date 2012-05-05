using System;
using System.Collections.Generic;

namespace ChainOfResponsibilityPattern
{
    internal class Program
    {
        private static void Main()
        {
            var parcelList =
                new List<Parcel>
                    {
                        new Parcel {IsInsured = false, Value = 2500m},
                        new Parcel {IsInsured = true, Value = 10m},
                        new Parcel {IsInsured = false, Value = 10m},
                        new Parcel {IsInsured = true, Value = 0m},
                        new Parcel {IsInsured = false, Value = 45m},
                        new Parcel {IsInsured = false, Value = 5m},
                        new Parcel {IsInsured = false, Value = 150m},
                    };

            var budgetHandler = new ParcelHandlerBudget();
            var normalHandler = new ParcelHandlerNormal();
            var deluxeHandler = new ParcelHandlerDeluxe();

            budgetHandler.SetNewHandler(normalHandler);
            normalHandler.SetNewHandler(deluxeHandler);

            foreach (Parcel parcel in parcelList)
            {
                try
                {
                    string result = budgetHandler.Handle(parcel);
                    Console.WriteLine(result);
                }
                catch (Exception)
                {
                    Console.WriteLine("Parcel rejected");
                }
            }

            Console.ReadKey();
        }
    }
}