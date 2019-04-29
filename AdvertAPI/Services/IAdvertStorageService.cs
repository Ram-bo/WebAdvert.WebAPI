using System.Threading.Tasks;
using AdvertAPI.Models;

namespace AdvertAPI.Services
{
    public interface IAdvertStorageService
    {
        public Task<string> Add (AdvertModel model);

        public Task Confirm (ConfirmAdvertModel model);

    }
}
