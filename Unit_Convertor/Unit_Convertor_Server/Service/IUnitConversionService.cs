using Data.Shared.Models;
using System.Collections.Generic;

namespace Unit_Convertor_Server.Service
{
    public interface IUnitConversionService
    {
        List<Factor> GetConversionFactors(string dbNmae);
        List<Unit> GetConversionUnits(string dbName);
    }
}
