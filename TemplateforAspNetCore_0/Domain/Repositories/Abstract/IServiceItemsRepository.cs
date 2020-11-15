using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateforAspNetCore_0.Domain.Entities;

namespace TemplateforAspNetCore_0.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entitiy);
        void DeleteServiceItem(Guid id);
    }
}
