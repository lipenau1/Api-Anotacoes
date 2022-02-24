using AN.Api.Model;
using AN.Api.Repositories.Interfaces;
using AN.Api.Services.Interfaces;

namespace AN.Api.Services
{
    public class AttachmentService : Service<Attachment>, IAttachmentService
    {
        public AttachmentService(IAttachmentRepository repository) : base(repository)
        {
        }
    }
}
