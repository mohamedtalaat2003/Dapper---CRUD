using DapperBiggnerCourse.Models;

namespace DapperBiggnerCourse.Repositories
{
    public interface IVideoGameRepository
    {
        Task<List<VideoGame>> GetAllAsync();
        Task<VideoGame> GetBydAsyc(int id);
        Task AddAsync(VideoGame videoGame);
        Task UpdateAsync(VideoGame videoGame);
        Task DeleteAsync(int id);
    }
}
