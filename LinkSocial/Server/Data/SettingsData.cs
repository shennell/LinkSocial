using LinkSocial.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkSocial.Server.Data
{
    public class SettingsData : ISettingsData
    {
        private readonly ApplicationDbContext _dbContext;

        public SettingsData(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddSettings(Settings settings)
        {
            
                try
                {
                    _dbContext.PageSettings.Add(settings);
                    _dbContext.SaveChanges();
                }
                catch
                {
                    throw;
                }
            
            
        }

        public Settings GetSettings(string pageName)
        {
            try{
                return _dbContext.PageSettings.Where(s => s.PageName == pageName).FirstOrDefault();
            }
            catch{
                throw;
            }
        }

        public void UpdateSettings(Settings settings)
        {
            /*var existingSettings = _dbContext.Set<Settings>().Local.FirstOrDefault(entry => entry.ID.Equals(settings.ID));
            if (existingSettings == null)
            {
                try
                {
                    _dbContext.PageSettings.Add(settings);
                    _dbContext.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
            else
            {*/
                try
                {
                    //_dbContext.Entry(settings).State = EntityState.Detached;
                    _dbContext.Entry(settings).State = EntityState.Modified;
                    _dbContext.PageSettings.Update(settings);
                    _dbContext.SaveChanges();
                }
                catch
                {
                    throw;
                }
                
            //}
        }
    }
}
