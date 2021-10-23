using System.Collections.Generic;
using Productivo.Core.Entities;

namespace Productivo.Core.Services
{
    public class POMetrics
    {
        /// <summary>
        /// Method that returns the total time picking up
        /// </summary>
        /// <param name="ImportDetails"></param>
        /// <returns></returns>
        public static double POSubTotalItems(IEnumerable<ImportDetailEntity> importDetails)
        {
            double result = 0;
            foreach (var importDetail in importDetails)
            {
                result += ((double)importDetail.Quantity* (double)importDetail.Amount);
            }
            return (result);
        }
    }
}
