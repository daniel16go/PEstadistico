using System;
using System.Collections.Generic;
using Productivo.Core.Entities;
using Productivo.Core.ViewModels.ProductionOrders;

namespace Productivo.Core.Services
{
    public class OEEMetrics
    {
        /// <summary>
        /// Method that returns the total time picking up
        /// </summary>
        /// <param name="produccionOrderDetails"></param>
        /// <returns></returns>
        public static double TimePickingUp(IEnumerable<ProductionOrderDetailEntity> produccionOrderDetails)
        {
            double result = 0;
            foreach (ProductionOrderDetailEntity orderDetail in produccionOrderDetails)
            {
                result += (double)orderDetail.TuneUp;
            }
            return (result);
        }

        /// <summary>
        /// Method that returns the total production
        /// </summary>
        /// <param name="produccionOrderDetails"></param>
        /// <returns></returns>
        public static double TotalProduction(IEnumerable<ProductionOrderDetailEntity> produccionOrderDetails)
        {
            double result = 0;
            foreach (ProductionOrderDetailEntity orderDetail in produccionOrderDetails)
            {
                result += (double)orderDetail.ProdQuantity;
            }
            return (result);
        }

        public static double TotalProcessLosses(List<ProductionStopEntity> productionStops)
        {
            double processLosses = 0;
            foreach(ProductionStopEntity stop in productionStops)
            {
                double stopTime = ((TimeSpan)(stop.FinishDateTime - stop.StartDateTime)).TotalMinutes;
                processLosses += stopTime * double.Parse(stop.Stops.Cost.ToString());
            }
            return processLosses;

        }

        /// <summary>
        /// Method that returns the total oddment production
        /// </summary>
        /// <param name="produccionOrderDetails"></param>
        /// <returns></returns>
        public static double TotalOddment(IEnumerable<ProductionOrderDetailEntity> produccionOrderDetails)
        {
            double result = 0;
            foreach (ProductionOrderDetailEntity orderDetail in produccionOrderDetails)
            {
                result += (double)orderDetail.OddmentQuantity;
            }
            return (result);
        }

        /// <summary>
        /// Method that returns the total Wast Quantity Production
        /// </summary>
        /// <param name="produccionOrderDetails"></param>
        /// <returns></returns>
        public static double TotalWast(IEnumerable<ProductionOrderDetailEntity> produccionOrderDetails)
        {
            double result = 0;
            foreach (ProductionOrderDetailEntity orderDetail in produccionOrderDetails)
            {
                result += (double)orderDetail.WasteQuantity;
            }
            return (result);
        }

        /// <summary>
        /// Method that returns the total Stop Time
        /// </summary>
        /// <param name="produccionOrderDetails"></param>
        /// <returns></returns>
        public static double TotalStopTime(IEnumerable<ProductionStopEntity> produccionStops)
        {
            double result = 0;
            foreach (ProductionStopEntity productionStop in produccionStops)
            {
                TimeSpan stopTime = (TimeSpan)(productionStop.FinishDateTime - productionStop.StartDateTime);
                result += stopTime.TotalMinutes;
            }
            return (result);
        }

        public static double TotalProductionTime(ShiftEntity shift)
        {
            double time = ((shift.ShiftEnd - shift.ShiftStart).TotalMinutes) - shift.RestTimeShift;
            return time;
        }

        public static double availability(Object productionOrderDetail)
        {
            double availabilitiTime = 0;
            double TotalProdution = 0;
            double TotalOperativeTime = 0;


            if (productionOrderDetail.GetType().Equals(new ProductionOrderDetailViewModel().GetType()))
            {
                ProductionOrderDetailViewModel model = (ProductionOrderDetailViewModel)productionOrderDetail;
                TotalProdution = TotalProductionTime(model.productionOrder.Shifts);
                TotalOperativeTime = TotalProdution - TotalStopTime(model.productionStops) - TimePickingUp(model.productionOrderDetails);
            }
            else if (productionOrderDetail.GetType().Equals(new ProductionOrderDetailEntity().GetType()))
            {
                ProductionOrderDetailEntity model = (ProductionOrderDetailEntity)productionOrderDetail;
                TotalProdution = ((TimeSpan)(model.FinishDateTime - model.StartDateTime)).TotalMinutes;
                TotalOperativeTime = TotalProdution - (double)model.TuneUp;
            }
            if (TotalProdution > 0)
            {
                availabilitiTime = TotalOperativeTime / TotalProdution;
            }

            return availabilitiTime;
        }

        public static double quality(Object productionOrderDetail)
        {
            double qualityValue = 0;
            double productionUnit = 0;
            double oddmentUnit = 0;

            if (productionOrderDetail.GetType().Equals(new ProductionOrderDetailViewModel().GetType()))
            {
                ProductionOrderDetailViewModel model = (ProductionOrderDetailViewModel)productionOrderDetail;
                productionUnit = TotalProduction(model.productionOrderDetails);
                oddmentUnit = TotalOddment(model.productionOrderDetails);
            }
            else if (productionOrderDetail.GetType().Equals(new ProductionOrderDetailEntity().GetType()))
            {
                ProductionOrderDetailEntity model = (ProductionOrderDetailEntity)productionOrderDetail;
                productionUnit = (double)model.ProdQuantity;
                oddmentUnit = (double)model.OddmentQuantity;
            }

            if ((productionUnit + oddmentUnit) > 0)
            {
                qualityValue = productionUnit / (productionUnit + oddmentUnit);
            }


            return qualityValue;
        }

        public static double performance(Object productionOrderDetail)
        {
            double performanceValue = 0;
            double outputStandard = 0;
            double TotalOperativeTime = 0;

            if (productionOrderDetail.GetType().Equals(new ProductionOrderDetailViewModel().GetType()))
            {
                ProductionOrderDetailViewModel model = (ProductionOrderDetailViewModel)productionOrderDetail;
                TotalOperativeTime = TotalProductionTime(model.productionOrder.Shifts) - TotalStopTime(model.productionStops) - TimePickingUp(model.productionOrderDetails);

                foreach (ProductionOrderProcessEntity process in model.productionOrderProcesses)
                {
                    outputStandard += (double)process.Machines.OutputStandard;
                }

                if (model.productionOrderProcesses.Count > 0)
                {
                    outputStandard /= model.productionOrderProcesses.Count;
                    performanceValue = TotalOperativeTime * outputStandard;

                    performanceValue = TotalProduction(model.productionOrderDetails) / performanceValue;
                }
            }
            else if (productionOrderDetail.GetType().Equals(new ProductionOrderDetailEntity().GetType()))
            {
                ProductionOrderDetailEntity model = (ProductionOrderDetailEntity)productionOrderDetail;
                TotalOperativeTime = ((TimeSpan)(model.FinishDateTime - model.StartDateTime)).TotalMinutes - (double)model.TuneUp;
                outputStandard = (double)model.Speed;

                performanceValue = TotalOperativeTime * outputStandard;
                performanceValue = (double)model.ProdQuantity / performanceValue;

            }

            return performanceValue;
        }

        public static double OEE(Object productionOrderDetail)
        {
            double oee = 0;
            double availabilityTime = availability(productionOrderDetail);
            double qualityValue = quality(productionOrderDetail);
            double performanceValue = performance(productionOrderDetail);


            oee = availabilityTime * qualityValue * performanceValue;
            return oee * 100;
        }
    }
}
