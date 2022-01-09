using PlatformService.Models;

namespace IPlatformService.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAll();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform plat);
    }
}