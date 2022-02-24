using AN.Api.Model;
using System;
using System.Collections.Generic;

namespace AN.Api.AppServices.Interfaces
{
    public interface IAttachmentAppService
    {
        Attachment Add(Attachment attachment);
        void Update(Attachment attachment);
        void Remove(Guid id);
        IEnumerable<Attachment> GetAll();
        Attachment GetById(int id);
    }
}
