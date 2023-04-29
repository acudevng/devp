using System;
using ACU.Portals.Apply.Enum;
using Volo.Abp.Application.Dtos;

namespace ACU.Portals.Apply.Services.Dtos.ApplicationUpload
{
	public class ApplicationUploadDto:EntityDto<long>
	{
		public long StudentId { get; set; }
		public long FilePath { get; set; }
		public DocumentDefinition DocumentType{get;set;}
	}
}

