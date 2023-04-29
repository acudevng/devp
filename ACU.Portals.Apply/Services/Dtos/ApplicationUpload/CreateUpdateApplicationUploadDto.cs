using System;
using ACU.Portals.Apply.Enum;

namespace ACU.Portals.Apply.Services.Dtos.ApplicationUpload
{
	public class CreateUpdateApplicationUploadDto
	{
        public long StudentId { get; set; }
        public long FilePath { get; set; }
        public DocumentDefinition DocumentType { get; set; }
    }
}

