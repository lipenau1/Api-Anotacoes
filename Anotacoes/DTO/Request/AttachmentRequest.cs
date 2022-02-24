using Microsoft.AspNetCore.Http;

namespace AN.Api.DTO.Request
{
    public class AttachmentRequest
    {
        public IFormFile File { get; set; }
    }
}
