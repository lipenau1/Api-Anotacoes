using System;

namespace AN.Api.Model
{
    public class Attachment
    {
        public Attachment(Guid anexoId, string nomeAnexo, Guid taskId)
        {
            Id = Guid.NewGuid();
            AnexoId = anexoId;
            NomeAnexo = nomeAnexo;
            TaskId = taskId;
        }

        public Attachment() { }
        public Guid Id { get; set; }
        public Guid AnexoId { get; set; }
        public string NomeAnexo { get; set; }
        public Guid TaskId { get; set; }
        public Tasks Task { get; set; }
    }
}
