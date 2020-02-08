using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvertApi.Models;

namespace AdvertApi.Interfaces
{
    public interface IAdvertStorageService
    {
        Task<string> Add(AdvertModel model);
        Task Confirm(ConfirmAdvertModel model);
    }
}
