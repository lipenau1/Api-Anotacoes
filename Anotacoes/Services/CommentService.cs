using AN.Api.Model;
using AN.Api.Repositories.Interfaces;
using AN.Api.Services.Interfaces;

namespace AN.Api.Services
{
    public class CommentService : Service<Comment>, ICommentService
    {
        public CommentService(ICommentRepository commentRepository) : base(commentRepository)
        {
        }
    }
}
