using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AreaUsingOops.Model;
using AreaUsingOops.Calculation;
namespace AreaUsingOops.Controllers
{
    [Route("api/Area")]
    [ApiController]
    public class AreaOfShape : ControllerBase
    {
        private readonly AreaCalculation _areaCalculation;
        public AreaOfShape(AreaCalculation areaCalculation)
        {
            _areaCalculation = areaCalculation;
        }
        [HttpPost]
        public double Area([FromBody] ShapeData dimension)
        {
            double result = _areaCalculation.Area(dimension);
            return result;
        }
    }
}
