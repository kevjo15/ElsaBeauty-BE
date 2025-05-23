using Domain_Layer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application_Layer.Interfaces
{
    public interface IServiceRepository
    {
        Task<IEnumerable<ServiceModel>> GetAllServicesAsync();
        Task<ServiceModel> GetServiceByIdAsync(Guid serviceId);
        Task<bool> AddServiceAsync(ServiceModel service);
        Task<bool> UpdateServiceAsync(ServiceModel service);
        Task DeleteServiceAsync(Guid id);
        Task<IEnumerable<ServiceModel>> GetServicesByCategoryAsync(Guid categoryId);
    }
}
