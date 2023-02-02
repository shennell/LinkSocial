using LinkSocial.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LinkSocial.Server.Data
{
    public class LinkData : ILinkData
    {
        private readonly ApplicationDbContext _dbContext;

        public LinkData(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Link> GetUserLinks(string pageName)
        {
            try{
                return _dbContext.Links.Where(l => l.PageName == pageName);
            }
            catch{
                throw;
            }
        }

        public IEnumerable<Link> GetActiveLinks(string pageName)
        {
            try{
                return _dbContext.Links.Where(l => l.PageName == pageName && l.Active == true);
            }
            catch{
                throw;
            }
        }

        public int GetNumberOfLinks(string pageName)
        {
            try{
                return _dbContext.Links.Where(l => l.PageName == pageName).Count();
            }
            catch {
                return 0;
            }
        }

        public int GetMaxPosition(string pageName)
        {
            try{
                return _dbContext.Links.Max(l => l.Position);
            }
            catch{
                return 1;
            }
        }

        public void UpdateLinkStatus(Link link)
        {
            try{
                _dbContext.Entry(link).Property("Active").IsModified = true;
                _dbContext.SaveChanges();
            }
            catch{
                throw;
            }
        }

        public void UpdateOrderOfLinks(List<Link> linksList)
        {
            try{
                foreach(Link link in linksList)
                {
                    var l = _dbContext.Links.Where(l => l.ID.Equals(link.ID)).FirstOrDefault();
                    if(l!=null)
                    {
                        l.Position = link.Position;
                    }
                }
                //_dbContext.UpdateRange(linksList);
                _dbContext.SaveChanges();
            }catch{
                throw;
            }
        }

        public void UpdateLink(Link link)
        {
            try{
                _dbContext.Entry(link).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch{
                throw;
            }
        }

        public Link GetLinkData(int id)
        {
            try{
                Link link = _dbContext.Links.Find(id);
                return link;
            }
            catch{
                throw;
            }
        }

        public void AddLink(Link link)
        {
            try{
                _dbContext.Links.Add(link);
                _dbContext.SaveChanges();
            }
            catch{
                throw;
            }
        }

        public void DeleteLink(int id)
        {
            try{
                Link l = _dbContext.Links.Find(id);
                _dbContext.Remove(l);
               _dbContext.SaveChanges();
            }
            catch{
                throw;
            }
        }
    }
}
