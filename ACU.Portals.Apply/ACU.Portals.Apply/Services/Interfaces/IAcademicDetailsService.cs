using System;
using ACU.Portals.Apply.Services.Dtos.AcademicDetails;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ACU.Portals.Apply.Services.Interfaces
{
	public interface IAcademicDetailsService: ICrudAppService< //Defines CRUD methods
        AcademicDetailsDto, //Used to show academic details
        long, //Primary key of the academic entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting on getting a list of academic details
        CreateUpdateAcademicDetailsDto, //Used to create a new Academic Details
        CreateUpdateAcademicDetailsDto> //Used to update a academic details
    {
		
	}
}

