using MediatR;
using Application_Layer.DTOs;

namespace Application_Layer.Queries.CategoryQueries
{
    public class GetAllCategoriesQuery : IRequest<IEnumerable<CategoryNameDTO>>
    {
    }
}