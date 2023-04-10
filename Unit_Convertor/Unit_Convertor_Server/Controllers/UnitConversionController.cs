using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data.Shared.Models;
using Unit_Convertor_Server.Service;
using Unit_Convertor_Server.Models;
using Distance = Data.Shared.Models.Distance;
using Temperature = Data.Shared.Models.Temperature;
using Weight = Data.Shared.Models.Weight;

namespace Unit_Convertor_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitConversionController : ControllerBase
    {
        private readonly IUnitConversionService ConversionService;

        public UnitConversionController(IUnitConversionService _conversionService)
        {
            ConversionService = _conversionService;
        }

        [HttpGet("data")]
        public ActionResult GetPageData([FromHeader]string dbName)
        {
            if(dbName == "Distances")
            {
                var distance = new Distance();
                distance.Factors = ConversionService.GetConversionFactors(dbName);
                distance.Units = ConversionService.GetConversionUnits(dbName);

                return Ok(distance);
            }
            else if (dbName == "Temperature")
            {
                var temperature = new Temperature();
                temperature.Factors = ConversionService.GetConversionFactors(dbName);
                temperature.Units = ConversionService.GetConversionUnits(dbName);

                return Ok(temperature);
            }
            else 
            {
                var weight = new Weight();
                weight.Factors = ConversionService.GetConversionFactors(dbName);
                weight.Units = ConversionService.GetConversionUnits(dbName);

                return Ok(weight);
            }
        }
    }
}
