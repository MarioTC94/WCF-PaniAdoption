using Adoption.Contract.DataContract;
using Adoption.Core.Models;
using AutoMapper;
using System.Collections.Generic;
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

			CreateMap<Province, KeyValuePairDTO>()
				.ForMember(kv => kv.Description, opt => opt.MapFrom(pr => pr.Name));

			CreateMap<County, KeyValuePairDTO>()
				.ForMember(kv => kv.Description, opt => opt.MapFrom(co => co.Name));

			CreateMap<District, KeyValuePairDTO>()
				.ForMember(dr => dr.Description, opt => opt.MapFrom(di => di.Name));

			CreateMap<Address, AddressDTO>()
				.ForMember(dr => dr.Description, opt => opt.MapFrom(di => di.AddressDescription));

			CreateMap<MarriageInformation, MarriageInformationDTO>()
				.ForMember(mr => mr.Address, opt => opt.MapFrom(mrd => mrd.Addresses.FirstOrDefault()));

			CreateMap<WorkerType, KeyValuePairDTO>();
			CreateMap<StateFile, KeyValuePairDTO>();
			CreateMap<RoomHouse, KeyValuePairDTO>();
			CreateMap<MaritalState, KeyValuePairDTO>();

			CreateMap<AdoptionProcess, AdoptionRequestDTO>();
			CreateMap<JobInformation, JobInformationDTO>();

			CreateMap<User,UserDTO>();

			//DTO to Models
			CreateMap<SaveJobInformationDTO, JobInformation>();
			CreateMap<SaveAddressDTO, Address>()
				.ForMember(ad => ad.AddressDescription, opt => opt.MapFrom(sd => sd.Description));

			CreateMap<SaveMarriageInformationDTO, MarriageInformation>();

			//CreateMap<SaveMarriageInformationDTO, MarriageInformation>().AfterMap((sm, mi, map) =>
			//{
			//	if (mi.Addresses.Any())
			//	{
			//		map.Mapper.Map(sm.Address, mi.Addresses.First());
			//	}
			//	else {
			//		var result = map.Mapper.Map<Address>(sm.Address);
			//		mi.Addresses = new Collection<Address>();
			//		mi.Addresses.Add(result);
			//	}

			//});

			CreateMap<SavePersonDTO, Person>()
				.ForMember(ar => ar.JobInformation, opt => opt.MapFrom(pe => new Collection<SaveJobInformationDTO> {
							pe.JobInformation
				}));

			//CreateMap<SavePersonDTO, Person>().AfterMap((sp, pe, map) =>
			//{
			//	if (pe.JobInformation.Any())
			//	{
			//		map.Mapper.Map(sp.JobInformation, pe.JobInformation.First());
			//	}
			//	else {
			//		var result = map.Mapper.Map<JobInformation>(sp.JobInformation);
			//		pe.JobInformation = new Collection<JobInformation>();
			//		pe.JobInformation.Add(result);
			//	}

			//});

			CreateMap<SaveAdoptionRequestDTO, AdoptionProcess>()
				.ForMember(ard => ard.Id, opt => opt.Ignore());

		}
	}
}