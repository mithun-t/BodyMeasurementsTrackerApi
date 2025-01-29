namespace BodyMeasurementsTrackerApi.Models
{
    public class BodyMeasurementDto
    {
        public required DateOnly MeasuredDate { get; set; }
        public required double BodyWeight { get; set; }
        public double BodyFatPercentage { get; set; }
        public double? Neck { get; set; }
        public double? Shoulder { get; set; }
        public double? Chest { get; set; }
        public double? Biceps { get; set; }
        public double? Forearm { get; set; }
        public double? Waist { get; set; }
        public double? Hips { get; set; }
        public double? Thighs { get; set; }
        public double? Calves { get; set; }
        public string? ProgressPicture { get; set; }
        public string? Notes { get; set; }
    }
}
