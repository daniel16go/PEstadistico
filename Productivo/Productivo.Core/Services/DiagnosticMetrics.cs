using System;
using System.Collections.Generic;
using System.Linq;
using Productivo.Core.Entities;

namespace Productivo.Core.Services
{
    public class DiagnosticMetrics
    {
        
        #region Diagnostic Metrics De la habilidad del trabajador
        /// <summary>
        /// Method that returns the total execution of the diagnostic
        /// </summary>
        /// <param name="diagnosticDetails"></param>
        /// <returns></returns>
        public static double Execution(IEnumerable<DiagnosticDetailEntity> diagnosticDetails)
        {
            double result = 0;

            foreach (var diagnosticDetail in diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 1))
            {
                result += (double)diagnosticDetail.Execution;
            }

            return (result);
        }

        /// <summary>
        /// Method that returns the total execution of the diagnostic
        /// </summary>
        /// <param name="diagnosticDetails"></param>
        /// <returns></returns>
        public static double CalificationTotal(IEnumerable<DiagnosticDetailEntity> diagnosticDetails)
        {
            double result = 0;

            foreach (var diagnosticDetail in diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 1))
            {
                result += (double)(diagnosticDetail.ModelQuestions.WeightQuestion * diagnosticDetail.Execution);
            }

            return (result);
        }

        /// <summary>
        /// Method that returns the total execution of the diagnostic
        /// </summary>
        /// <param name="diagnosticDetails"></param>
        /// <returns></returns>
        public static double WeightTotal(IEnumerable<DiagnosticDetailEntity> diagnosticDetails)
        {
            double result = 0;
            foreach (var diagnosticDetail in diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 1))
            {
                result += (double)diagnosticDetail.ModelQuestions.WeightQuestion;
            }
            return (result);
        }
        #endregion
        #region Diagnostic Metrics De los estandares
        /// <summary>
        /// Method that returns the total execution of the diagnostic
        /// </summary>
        /// <param name="diagnosticDetails"></param>
        /// <returns></returns>
        public static double ExecutionStandards(IEnumerable<DiagnosticDetailEntity> diagnosticDetails)
        {
            double result = 0;
            foreach (var diagnosticDetail in diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 2))
            {
                result += (double)diagnosticDetail.Execution;
            }
            return (result);
        }

        /// <summary>
        /// Method that returns the total execution of the diagnostic
        /// </summary>
        /// <param name="diagnosticDetails"></param>
        /// <returns></returns>
        public static double CalificationTotalStandards(IEnumerable<DiagnosticDetailEntity> diagnosticDetails)
        {
            double result = 0;
            foreach (var diagnosticDetail in diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 2))
            {
                result += (double)(diagnosticDetail.ModelQuestions.WeightQuestion * diagnosticDetail.Execution);
            }
            return (result);
        }

        /// <summary>
        /// Method that returns the total execution of the diagnostic
        /// </summary>
        /// <param name="diagnosticDetails"></param>
        /// <returns></returns>
        public static double WeightTotalStandards(IEnumerable<DiagnosticDetailEntity> diagnosticDetails)
        {
            double result = 0;
            foreach (var diagnosticDetail in diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 2))
            {
                result += (double)diagnosticDetail.ModelQuestions.WeightQuestion;
            }
            return (result);
        }
        #endregion
        #region Diagnostic Metrics De la condicion de trabajo
        /// <summary>
        /// Method that returns the total execution of the diagnostic
        /// </summary>
        /// <param name="diagnosticDetails"></param>
        /// <returns></returns>
        public static double ExecutionWork(IEnumerable<DiagnosticDetailEntity> diagnosticDetails)
        {
            double result = 0;
            foreach (var diagnosticDetail in diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 3))
            {
                result += (double)diagnosticDetail.Execution;
            }
            return (result);
        }

        /// <summary>
        /// Method that returns the total execution of the diagnostic
        /// </summary>
        /// <param name="diagnosticDetails"></param>
        /// <returns></returns>
        public static double CalificationTotalWork(IEnumerable<DiagnosticDetailEntity> diagnosticDetails)
        {
            double result = 0;
            foreach (var diagnosticDetail in diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 3))
            {
                result += (double)(diagnosticDetail.ModelQuestions.WeightQuestion * diagnosticDetail.Execution);
            }
            return (result);
        }

        /// <summary>
        /// Method that returns the total execution of the diagnostic
        /// </summary>
        /// <param name="diagnosticDetails"></param>
        /// <returns></returns>
        public static double WeightTotalWork(IEnumerable<DiagnosticDetailEntity> diagnosticDetails)
        {
            double result = 0;
            foreach (var diagnosticDetail in diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 3))
            {
                result += (double)diagnosticDetail.ModelQuestions.WeightQuestion;
            }
            return (result);
        }
        #endregion
        #region Diagnostic Metrics De la condicion tecnica
        /// <summary>
        /// Method that returns the total execution of the diagnostic
        /// </summary>
        /// <param name="diagnosticDetails"></param>
        /// <returns></returns>
        public static double ExecutionTecnique(IEnumerable<DiagnosticDetailEntity> diagnosticDetails)
        {
            double result = 0;
            foreach (var diagnosticDetail in diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 4))
            {
                result += (double)diagnosticDetail.Execution;
            }
            return (result);
        }

        /// <summary>
        /// Method that returns the total execution of the diagnostic
        /// </summary>
        /// <param name="diagnosticDetails"></param>
        /// <returns></returns>
        public static double CalificationTotalTecnique(IEnumerable<DiagnosticDetailEntity> diagnosticDetails)
        {
            double result = 0;
            foreach (var diagnosticDetail in diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 4))
            {
                result += (double)(diagnosticDetail.ModelQuestions.WeightQuestion * diagnosticDetail.Execution);
            }
            return (result);
        }

        /// <summary>
        /// Method that returns the total execution of the diagnostic
        /// </summary>
        /// <param name="diagnosticDetails"></param>
        /// <returns></returns>
        public static double WeightTotalTecnique(IEnumerable<DiagnosticDetailEntity> diagnosticDetails)
        {
            double result = 0;
            foreach (var diagnosticDetail in diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 4))
            {
                result += (double)diagnosticDetail.ModelQuestions.WeightQuestion;
            }
            return (result);
        }
        #endregion
        #region Diagnostic Metrics Del proceso - Metodo
        /// <summary>
        /// Method that returns the total execution of the diagnostic
        /// </summary>
        /// <param name="diagnosticDetails"></param>
        /// <returns></returns>
        public static double ExecutionMethod(IEnumerable<DiagnosticDetailEntity> diagnosticDetails)
        {
            double result = 0;
            foreach (var diagnosticDetail in diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 5))
            {
                result += (double)diagnosticDetail.Execution;
            }
            return (result);
        }

        /// <summary>
        /// Method that returns the total execution of the diagnostic
        /// </summary>
        /// <param name="diagnosticDetails"></param>
        /// <returns></returns>
        public static double CalificationTotalMethod(IEnumerable<DiagnosticDetailEntity> diagnosticDetails)
        {
            double result = 0;
            foreach (var diagnosticDetail in diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 5))
            {
                result += (double)(diagnosticDetail.ModelQuestions.WeightQuestion * diagnosticDetail.Execution);
            }
            return (result);
        }

        /// <summary>
        /// Method that returns the total execution of the diagnostic
        /// </summary>
        /// <param name="diagnosticDetails"></param>
        /// <returns></returns>
        public static double WeightTotalMethod(IEnumerable<DiagnosticDetailEntity> diagnosticDetails)
        {
            double result = 0;
            foreach (var diagnosticDetail in diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 5))
            {
                result += (double)diagnosticDetail.ModelQuestions.WeightQuestion;
            }
            return (result);
        }
        #endregion
        #region Diagnostic Metrics De la gestion gerencial
        /// <summary>
        /// Method that returns the total execution of the diagnostic
        /// </summary>
        /// <param name="diagnosticDetails"></param>
        /// <returns></returns>
        public static double ExecutionManage(IEnumerable<DiagnosticDetailEntity> diagnosticDetails)
        {
            double result = 0;
            foreach (var diagnosticDetail in diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 6))
            {
                result += (double)diagnosticDetail.Execution;
            }
            return (result);
        }

        /// <summary>
        /// Method that returns the total execution of the diagnostic
        /// </summary>
        /// <param name="diagnosticDetails"></param>
        /// <returns></returns>
        public static double CalificationTotalManage(IEnumerable<DiagnosticDetailEntity> diagnosticDetails)
        {
            double result = 0;
            foreach (var diagnosticDetail in diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 6))
            {
                result += (double)(diagnosticDetail.ModelQuestions.WeightQuestion * diagnosticDetail.Execution);
            }
            return (result);
        }

        /// <summary>
        /// Method that returns the total execution of the diagnostic
        /// </summary>
        /// <param name="diagnosticDetails"></param>
        /// <returns></returns>
        public static double WeightTotalManage(IEnumerable<DiagnosticDetailEntity> diagnosticDetails)
        {
            double result = 0;
            foreach (var diagnosticDetail in diagnosticDetails.Where(x => x.ModelQuestions.CategoryModelsId == 6))
            {
                result += (double)diagnosticDetail.ModelQuestions.WeightQuestion;
            }
            return (result);
        }
        #endregion



    }
}
