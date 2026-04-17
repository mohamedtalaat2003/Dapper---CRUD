using DapperBiggnerCourse.Models;
using DapperBiggnerCourse.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace DapperBiggnerCourse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGamesController : ControllerBase
    {
        private readonly IVideoGameRepository _videoGameRepository;

        public VideoGamesController(IVideoGameRepository videoGameRepository)
        {
            _videoGameRepository = videoGameRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<VideoGame>>> GetAllAsync()
        {
            var videoGames = await _videoGameRepository.GetAllAsync();
            return Ok(videoGames);
        }

        [HttpGet("{id}",Name = "GetByid")] // <= [HttpGet] [Route("{id}")
        public async Task<ActionResult<VideoGame>> GetByIdAsync(int id)
        {
            var videoGame = await _videoGameRepository.GetBydAsyc(id);
            if (videoGame == null) return NotFound("This video game does not exist in Data base");

            return Ok(videoGame);
        }
        [HttpPost]
        public async Task<ActionResult>AddAsync(VideoGame videoGame)
        {
          await _videoGameRepository.AddAsync(videoGame);
            return CreatedAtAction("GetById", new {id = videoGame.Id}, videoGame);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult>UpdateAsync(int id ,VideoGame videoGame)
        {
            var exist = await _videoGameRepository.GetBydAsyc(id);
            if (exist == null) return NotFound("Video Game Not found ");

            videoGame.Id = id;
            await _videoGameRepository.UpdateAsync(videoGame);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var Exist = await _videoGameRepository.GetBydAsyc(id);
            if (Exist == null) return NotFound("This Video Game not found");

            await _videoGameRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
