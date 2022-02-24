using AN.Api.AppServices.Interfaces;
using AN.Api.Model;
using AN.Api.Services.Interfaces;
using AN.Api.UoW.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace AN.Api.AppServices
{
    public class AttachmentAppService : IAttachmentAppService
    {
        private readonly IAttachmentService _attachmentService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AttachmentAppService(IAttachmentService attachmentAppService, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _attachmentService = attachmentAppService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Attachment Add(Attachment attachment)
        {
            var attachmentAdd = _attachmentService.Add(attachment);
            _unitOfWork.Commit();
            return attachmentAdd;
        }

        public IEnumerable<Attachment> GetAll()
        {
            return _attachmentService.GetAll();
        }

        public Attachment GetById(int id)
        {
            return _attachmentService.GetById(id);
        }

        public void Remove(Guid id)
        {
            _attachmentService.Remove(id);
        }

        public void Update(Attachment attachment)
        {
            _attachmentService.Update(attachment);
            _unitOfWork.Commit();
        }
    }
}
