using MediatR;
using Application_Layer.DTO_s;

public class GetServicesByCategoryQuery : IRequest<IEnumerable<ServiceDTO>>
{
    public Guid CategoryId { get; }

    public GetServicesByCategoryQuery(Guid categoryId)
    {
        CategoryId = categoryId;
    }
}