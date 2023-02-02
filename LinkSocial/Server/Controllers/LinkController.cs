using LinkSocial.Server.Data;
using LinkSocial.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkSocial.Server.Controllers
{
    /*[Route("api/[controller]")]*/
    [ApiController]
    public class LinkController : ControllerBase
    {
        private readonly ILinkData _linkData;
        public LinkController(ILinkData linkData)
        {
            _linkData = linkData;
        }

        [HttpGet]
        [Route("api/Links/{pageName}")]
        public IEnumerable<Link> GetLinks(string pageName)
        {
            return _linkData.GetUserLinks(pageName);
        }

        [HttpGet]
        [Route("api/Links/{pageName}/Active")]
        public IEnumerable<Link> GetActiveLinks(string pageName)
        {
            return _linkData.GetActiveLinks(pageName);
        }

        [HttpGet]
        [Route("api/NumberOfLinks/{pageName}")]
        public int GetNumberOfLinks(string pageName)
        {
            return _linkData.GetNumberOfLinks(pageName);
        }

        [HttpGet]
        [Route("api/MaxPosition/{pageName}")]
        public int GetMaxPosition(string pageName)
        {
            return _linkData.GetMaxPosition(pageName);
        }

        [HttpPost]
        [Route("api/Links/UpdateStatus")]
        public void UpdateLinkStatus([FromBody] Link link)
        {
            if (ModelState.IsValid)
                _linkData.UpdateLinkStatus(link);
        }

        [HttpPost]
        [Route("api/Links/UpdateOrderOfLinks")]
        public void UpdateOrderOfLinks([FromBody] List<Link> linksList)
        {
            if (ModelState.IsValid)
                _linkData.UpdateOrderOfLinks(linksList);
        }

        [HttpPost]
        [Route("api/Links/UpdateLink")]
        public void UpdateLink([FromBody] Link link)
        {
            if (ModelState.IsValid)
                _linkData.UpdateLink(link);
        }


        [HttpPost]
        [Route("api/Links/Create")]
        public void Create([FromBody] Link link)
        {
            if (ModelState.IsValid)
                _linkData.AddLink(link);
        }

        [HttpGet]
        [Route("api/Links/Details/{id}")]
        public Link Details(int id)
        {
            return _linkData.GetLinkData(id);
        }

        [HttpDelete]
        [Route("api/Links/Delete/{id}")]
        public void Delete(int id)
        {
            _linkData.DeleteLink(id);
        }
    }
}
