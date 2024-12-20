namespace Application_Layer.DTOs
{
    public class BookingDTO
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public Guid ServiceId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        // Add other properties as needed
    }
} 