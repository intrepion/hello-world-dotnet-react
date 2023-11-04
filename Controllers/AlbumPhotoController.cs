using Microsoft.AspNetCore.Mvc;

namespace hello_world_dotnet_react.Controllers;

[ApiController]
[Route("[controller]")]
public class AlbumPhotoController : ControllerBase
{
    private static readonly AlbumPhoto[] albumPhotos = new AlbumPhoto[]
    {
        new AlbumPhoto() {
            AlbumId = 1,
            Id = 1,
            Title = "accusamus beatae ad facilis cum similique qui sunt",
            Url = "https://via.placeholder.com/600/92c952",
            ThumbnailUrl = "https://via.placeholder.com/150/92c952",
        }
    };

    private readonly ILogger<AlbumPhotoController> _logger;

    public AlbumPhotoController(ILogger<AlbumPhotoController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetAlbumPhoto")]
    public IEnumerable<AlbumPhoto> Get()
    {
        return albumPhotos;
    }
}
