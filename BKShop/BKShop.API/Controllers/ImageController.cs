using BKShop.Data.EF;
using BKShop.ViewModels.Requests.Image;
using Microsoft.AspNetCore.Mvc;

namespace BKShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        public static IWebHostEnvironment _enviroment;

        public ImageController(IWebHostEnvironment enviroment)
        {
            _enviroment = enviroment;
        }



        [HttpPost]
        public async Task<string> Post([FromForm] ImageCreateRequest f)
        {
            try
            {
                if (f.files.Length > 0)
                {
                    if (!Directory.Exists(_enviroment.WebRootPath + "\\Upload\\"))
                    {
                        Directory.CreateDirectory(_enviroment.WebRootPath + "\\Upload\\");
                    }
                    using (FileStream fileStream = System.IO.File.Create(_enviroment.WebRootPath + "\\Upload\\" + f.files.FileName))
                    {
                        f.files.CopyTo(fileStream);
                        fileStream.Flush();
                        return "\\Upload\\" + f.files.FileName;
                    }
                }
                else
                {
                    return "Failed";
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }

        [HttpDelete("{imageName}")]
        public async Task<string> Delete([FromRoute] string imageName)
        {
            var imagePath = Path.Combine(_enviroment.WebRootPath,"Upload", imageName);
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
                return "Deleted success!";
            }
            else
            {
                return "Can not find image";
            }
        }
        //[HttpGet]
        //public async Task<IActionResult> Get([FromForm] string name)
        //{

        //}
    }
}
