using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WarioConsoleApp.Models;

namespace WarioConsoleApp.Services
{
    public class XmlDataDownloader : IDataDownloader
    {
        private readonly ILogger<XmlDataDownloader> _logger;
        public XmlDataDownloader(ILogger<XmlDataDownloader> logger)
        {
            _logger = logger;
        }
        public async Task<Wario?> DownloadAsync(string url)
        {
            using var HttpClient = new HttpClient();
            try
            {
                string xml = await HttpClient.GetStringAsync(url);
                XmlSerializer serializer = new XmlSerializer(typeof(Wario));
                using StringReader reader = new StringReader(xml);
                return (Wario?)serializer.Deserialize(reader);
            } catch(HttpRequestException ex)
            {
                _logger.LogError(ex, "Error downloading XML data from {Url}", url);
                return null;
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogError(ex, "Error deserializing XML data from {Url}", url);
                return null;
            }
        }
    }
}
