using Adoption.Contract;
using Adoption.Contract.DataContract;
using Adoption.Core.Models;
using AutoMapper;
using System.Collections.ObjectModel;
using System.Linq;

namespace MoviesService
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			//Models to DTO
			CreateMap<Province, ProvinceDTO>()
				.ForMember(pe => pe.Description, opt => opt.MapFrom(pd => pd.Name))
				.ForMember(pe => pe.Counties, opt => opt.MapFrom(c => c.Counties.
					Select(x => new CountyDTO
					{
						Description = x.Name,
						Id = x.Id,
						Districts = x.Districts.
							Select(d => new KeyValuePairDTO { Id = d.Id, Description = d.Name }).ToList()
					})));

			CreateMap<WorkerType, KeyValuePairDTO>();
			CreateMap<StateFile, KeyValuePairDTO>();
			CreateMap<RoomHouse, KeyValuePairDTO>();
			CreateMap<MaritalState, KeyValuePairDTO>();
			CreateMap<MarriageInformation, MarriageInformationDTO>();
			CreateMap<AdoptionProcess, AdoptionRequestDTO>();
			CreateMap<JobInformation, JobInformationDTO>();

			//DTO to Models
			CreateMap<SaveJobInformationDTO, JobInformation>();
			CreateMap<SaveMarriageInformationDTO, MarriageInformation>();
			CreateMap<SavePersonDTO, Person>()
				.ForMember(ar => ar.JobInformation, opt => opt.MapFrom(pe => new Collection<SaveJobInformationDTO> {
							pe.JobInformation
				}));

			CreateMap<SaveAdoptionRequestDTO, AdoptionProcess>()
				.ForMember(ard => ard.Id, opt => opt.Ignore());

		}
	}
}