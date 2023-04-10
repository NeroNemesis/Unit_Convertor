using Microsoft.EntityFrameworkCore;
using Data.Shared.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unit_Convertor_Server.Models;
using Distance = Data.Shared.Models.Distance;
using Temperature = Data.Shared.Models.Temperature;
using Weight = Data.Shared.Models.Weight;
using Unit = Data.Shared.Models.Unit;

namespace Unit_Convertor_Server.Service
{
    public class UnitConversionService : IUnitConversionService
    {
        private UnitConvertorContext Context = new();
        private Distance Distance;
        private Temperature Temperature;
        private Weight Weight;

        public List<Factor> GetConversionFactors(string dbName)
        {
            try
            {
                if(dbName == "Distances")
                {
                    Distance = new Distance();
                    foreach (var ConversionElement in Context.Distances.AsEnumerable())
                    {
                        Distance.Factors.Add
                        (
                            new Factor
                            {
                                UFrom = ConversionElement.Ufrom,
                                Value = ConversionElement.Factor,
                                UTo = ConversionElement.Uto
                            }
                        );
                    }

                    return Distance.Factors;
                }
                else if(dbName == "Temperatures")
                {
                    Temperature = new Temperature();
                    foreach (var ConversionElement in Context.Temperatures.AsEnumerable())
                    {
                        Temperature.Factors.Add
                        (
                            new Factor
                            {
                                UFrom = ConversionElement.Ufrom,
                                Value = ConversionElement.Factor,
                                UTo = ConversionElement.Uto
                            }
                        );
                    }

                    return Temperature.Factors;
                }
                else
                {
                    Weight = new Weight();
                    foreach (var ConversionElement in Context.Weights.AsEnumerable())
                    {
                        Weight.Factors.Add
                        (
                            new Factor
                            {
                                UFrom = ConversionElement.Ufrom,
                                Value = ConversionElement.Factor,
                                UTo = ConversionElement.Uto
                            }
                        );
                    }

                    return Weight.Factors;
                }
            }
            catch
            {
                throw;
            }
        }

        public List<Unit> GetConversionUnits(string dbName)
        {
            try
            {
                if (dbName == "Distances")
                {
                    Distance = new Distance();
                    foreach (var ConversionUnit in Context.DistanceUnits.AsEnumerable())
                    {
                        Distance.Units.Add
                        (
                            new Unit
                            {
                                Name = ConversionUnit.Name,
                                Value = ConversionUnit.Unit,
                            }
                        );
                    }

                    return Distance.Units;
                }
                else if (dbName == "Temperatures")
                {
                    Temperature = new Temperature();
                    foreach (var ConversionUnit in Context.TemperatureUnits.AsEnumerable())
                    {
                        Temperature.Units.Add
                        (
                            new Unit
                            {
                                Name = ConversionUnit.Name,
                                Value = ConversionUnit.Unit,
                            }
                        );
                    }

                    return Temperature.Units;
                }
                else
                {
                    Weight = new Weight();
                    foreach (var ConversionUnit in Context.WeightUnits.AsEnumerable())
                    {
                        Weight.Units.Add
                        (
                            new Unit
                            {
                                Name = ConversionUnit.Name,
                                Value = ConversionUnit.Unit,
                            }
                        );
                    }

                    return Weight.Units;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
