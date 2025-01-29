using Microsoft.AspNetCore.Mvc;
using BodyMeasurementsTrackerApi.Data;
using BodyMeasurementsTrackerApi.Models.Entities;
using BodyMeasurementsTrackerApi.Models;
namespace BodyMeasurementsTrackerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodyMeasurementController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public BodyMeasurementController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllBodyMeasurements()
        {
            var bodyMeasurements = dbContext.BodyMeasurements.ToList();
            return Ok(bodyMeasurements);
        }
        [HttpPost]
        public IActionResult SaveBodyMeasurement(BodyMeasurementDto bodyMeasurementDto)
        {
            var bodyMeasurementEntity = new BodyMeasurement
            {
                MeasuredDate = bodyMeasurementDto.MeasuredDate,
                BodyWeight = bodyMeasurementDto.BodyWeight,
                BodyFatPercentage = bodyMeasurementDto.BodyFatPercentage,
                Neck = bodyMeasurementDto.Neck,
                Shoulder = bodyMeasurementDto.Shoulder,
                Chest = bodyMeasurementDto.Chest,
                Biceps = bodyMeasurementDto.Biceps,
                Forearm = bodyMeasurementDto.Forearm,
                Waist = bodyMeasurementDto.Waist,
                Hips = bodyMeasurementDto.Hips,
                Thighs = bodyMeasurementDto.Thighs,
                Calves = bodyMeasurementDto.Calves,
                ProgressPicture = bodyMeasurementDto.ProgressPicture,
                Notes = bodyMeasurementDto.Notes
            };
            dbContext.BodyMeasurements.Add(bodyMeasurementEntity);
            dbContext.SaveChanges();
            return Ok(bodyMeasurementEntity);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetBodyMeasurementByID(int id)
        {
            var bodyMeasurements = dbContext.BodyMeasurements.Find(id);
            if (bodyMeasurements == null)
            {
                return NotFound();
            }
            return Ok(bodyMeasurements);
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteBodyMeasurement(int id) {
           var bodyMeasurement = dbContext.BodyMeasurements.Find(id);
            if (bodyMeasurement == null) {
                return NotFound();
            }
            dbContext.Remove(bodyMeasurement);
            dbContext.SaveChanges();
            return Ok(bodyMeasurement);
        }
    }
}