using AN.Api.Data;
using AN.Api.Model;
using AN.Api.Repositories.Interfaces;

namespace AN.Api.Repositories
{
    public class AttachmentRepository : Repository<Attachment>, IAttachmentRepository
    {
        public AttachmentRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
