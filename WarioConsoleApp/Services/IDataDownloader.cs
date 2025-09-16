using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarioConsoleApp.Models;

namespace WarioConsoleApp.Services
{
    public interface IDataDownloader
    {
        Task<Wario?> DownloadAsync(string url);
    }
}
