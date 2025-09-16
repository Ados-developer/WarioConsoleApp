using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarioConsoleApp.Models;
using WarioConsoleApp.Repositories;

namespace WarioConsoleApp.Services
{
    public class DataService
    {
        private readonly IDataDownloader _downloader;
        private readonly ILogger<DataService> _logger;
        private readonly WarioRepository _repository;

        public DataService(IDataDownloader downloader, ILogger<DataService> logger, WarioRepository repository)
        {
            _downloader = downloader;
            _logger = logger;
            _repository = repository;
        }
        public async Task Run(string url)
        {
            _logger.LogInformation("Downloading data from {Url}", url);
            Wario? data = await _downloader.DownloadAsync(url);
            if (data != null)
            {
                _logger.LogInformation("Data downloaded successfully");
                _logger.LogInformation("Data saved to database");
            }
            else
            {
                _logger.LogWarning("No data was downloaded.");
                _logger.LogWarning("An empty record was saved to the database.");
            }
            _repository.Save(data);
            
        }
    }
}
