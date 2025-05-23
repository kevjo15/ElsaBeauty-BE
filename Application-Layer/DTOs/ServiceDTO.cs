using System;

namespace Application_Layer.DTO_s
{
    public class ServiceDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal Price { get; set; }
    }
}
