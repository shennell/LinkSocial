using LinkSocial.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkSocial.Server.Data
{
    public interface ILinkData
    {
        IEnumerable<Link> GetUserLinks(string pageName);
        IEnumerable<Link> GetActiveLinks(string pageName);
        int GetNumberOfLinks(string pageName);
        int GetMaxPosition(string pageName);
        void UpdateLinkStatus(Link link);
        void UpdateOrderOfLinks(List<Link> linksList);
        void UpdateLink(Link link);
        Link GetLinkData(int id);
        void AddLink(Link link);
        void DeleteLink(int id);
    }
}
