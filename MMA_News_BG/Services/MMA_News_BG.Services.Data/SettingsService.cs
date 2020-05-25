namespace MMA_News_BG.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using MMA_News_BG.Data.Common.Repositories;
    using MMA_News_BG.Data.Models;
    using MMA_News_BG.Services.Mapping;

    public class SettingsService : ISettingsService
    {
        private readonly IDeletableEntityRepository<Setting> settingsRepository;

        public SettingsService(IDeletableEntityRepository<Setting> settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public int GetCount()
        {
            return this.settingsRepository.All().Count();
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.settingsRepository.All().To<T>().ToList();
        }
    }
}
