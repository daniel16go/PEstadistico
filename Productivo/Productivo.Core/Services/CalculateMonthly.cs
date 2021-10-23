using System;
using System.Collections.Generic;
using Productivo.Core.Entities;
using System.Linq;
using Productivo.Core.ViewModels.ProductionOrders;

namespace Productivo.Core.Services
{
    public class CalculateMonthly
    {
        public static int TotalTuneUpTime(List<ProductionOrderDetailViewModel> productionOrders)
        {
            int TuneUpTime = 0;
            foreach (ProductionOrderDetailViewModel item in productionOrders)
            {
                foreach (ProductionOrderDetailEntity productionOrder in item.productionOrderDetails)
                {
                    TuneUpTime += (int)productionOrder.TuneUp;
                }
            }
            return TuneUpTime;
        }


        public static IDictionary<string, int> TotalTTimeStopByMachine(List<ProductionOrderDetailViewModel> productionOrders)
        {
            IDictionary<string, int> totalTime = new Dictionary<string, int>();
            foreach (ProductionOrderDetailViewModel item in productionOrders)
            {
                foreach (ProductionStopEntity productionOrder in item.productionStops)
                {
                    if (!totalTime.ContainsKey(productionOrder.Machines.Name))
                    {
                        totalTime.Add(productionOrder.Machines.Name, (int)((TimeSpan)(productionOrder.FinishDateTime - productionOrder.StartDateTime)).TotalMinutes);
                    }
                    else
                    {
                        totalTime[productionOrder.Machines.Name] = totalTime[productionOrder.Machines.Name] + (int)((TimeSpan)(productionOrder.FinishDateTime - productionOrder.StartDateTime)).TotalMinutes;
                    }
                }
            }
            return totalTime;
        }

        public static IDictionary<string, int> TotalTTimeStopByEmployees(List<ProductionOrderDetailViewModel> productionOrders)
        {
            IDictionary<string, int> totalTime = new Dictionary<string, int>();
            foreach (ProductionOrderDetailViewModel item in productionOrders)
            {
                foreach (ProductionStopEntity productionOrder in item.productionStops)
                {
                    if (!totalTime.ContainsKey(productionOrder.Employees.FullName))
                    {
                        totalTime.Add(productionOrder.Employees.FullName, (int)((TimeSpan)(productionOrder.FinishDateTime - productionOrder.StartDateTime)).TotalMinutes);
                    }
                    else
                    {
                        totalTime[productionOrder.Employees.FullName] = totalTime[productionOrder.Employees.FullName] + (int)((TimeSpan)(productionOrder.FinishDateTime - productionOrder.StartDateTime)).TotalMinutes;
                    }
                }
            }
            return totalTime;
        }

        public static IDictionary<string, int> TotalTTimeStopByTypes(List<ProductionOrderDetailViewModel> productionOrders)
        {
            IDictionary<string, int> totalTime = new Dictionary<string, int>();
            foreach (ProductionOrderDetailViewModel item in productionOrders)
            {
                foreach (ProductionStopEntity productionOrder in item.productionStops)
                {
                    if (!totalTime.ContainsKey(productionOrder.Stops.Name))
                    {
                        totalTime.Add(productionOrder.Stops.Name, (int)((TimeSpan)(productionOrder.FinishDateTime - productionOrder.StartDateTime)).TotalMinutes);
                    }
                    else
                    {
                        totalTime[productionOrder.Stops.Name] = totalTime[productionOrder.Stops.Name] + (int)((TimeSpan)(productionOrder.FinishDateTime - productionOrder.StartDateTime)).TotalMinutes;
                    }
                }
            }
            return totalTime.OrderByDescending(x => x.Value).ToDictionary(x => x.Key,  x => x.Value);
        }
    }
}
