using AN.Api.Data;
using AN.Api.Model;
using AN.Api.Repositories.Interfaces;

namespace AN.Api.Repositories
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
