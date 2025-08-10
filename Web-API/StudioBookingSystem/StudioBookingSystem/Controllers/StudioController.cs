using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudioBookingSystem.Service.Interface;
using StudioBookingSystem.Service.Service;

namespace StudioBookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudioController : ControllerBase
    {
        private readonly IStudioService _studioService;

        public StudioController(IStudioService studioService)
        {
            _studioService=studioService;
        }

        [HttpGet("/api/studios")]
        public async Task<IActionResult> GetStudios()
        {
            // If no error
            var result = await _studioService.GetStudios();
            return Ok(ApiResponse.CreateSuccessResponse(result,200,"Data fetch successfully"));
        }
        [HttpGet("/api/studios/{id}")]
        public async Task<IActionResult> GetStudios(int id)
        {
            // If no error
            var result = await _studioService.GetStudioById(id);
            return Ok(ApiResponse.CreateSuccessResponse(result, 200, "Data fetch successfully"));
        }

    }
}
