using MediatR;
using System.Collections.Generic;
using Application_Layer.DTOs;

namespace Application_Layer.Queries.NotificationQueries
{
    public class GetUserNotificationsQuery : IRequest<List<NotificationDTO>>
    {
        public string UserId { get; set; }
    }
}
