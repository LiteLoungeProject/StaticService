using System;

namespace LiteLoungeProject.StaticService.Domain.Contracts.Options
{
    public class MemoryCacheOptions
    {
        public bool UseRepositoryMamoryCache { get; set; }

        public TimeSpan RepositoryMamoryCacheTimeout { get; set; }
    }
}
