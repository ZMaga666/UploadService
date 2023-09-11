using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UploadService.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        [HttpPost("upload")]
        public async Task<IActionResult> UploadAsync(IFormFile file)
        {
            try
            {
                if (file == null || file.Length == 0)
                {
                    return BadRequest("No file was provided.");
                }

                // Ensure a unique filename
                var uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;

                // Path to save the uploaded file
                var uploadPath = Path.Combine("wwwroot/uploads", uniqueFileName);

                using (var stream = new FileStream(uploadPath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                return Ok("/uploads/" + uniqueFileName);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }


        [HttpPost("uploads")]
        public async Task<IActionResult> UploadsAsync([FromForm] IFormFileCollection files)
        {
            try
            {
                if (files == null || files.Count == 0)
                {
                    return BadRequest("No files were provided.");
                }
                List<string> photoUrls = new();
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        // Ensure a unique filename
                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                        photoUrls.Add("wwwroot/uploads/" + uniqueFileName);
                        // Path to save the uploaded file
                        var uploadPath = Path.Combine("wwwroot/uploads", uniqueFileName);

                        using (var stream = new FileStream(uploadPath, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }
                    }
                }
                return Ok(photoUrls);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}