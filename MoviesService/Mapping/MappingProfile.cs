using Adoption.Contract.DataContract;
using Adoption.Core.Models;
using AutoMapper;
using System.Linq;

namespace MoviesService
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Province, ProvinceDTO>()
				.ForMember(pe => pe.Name, opt => opt.MapFrom(pd => pd.Name))
				.ForMember(pe => pe.Counties, opt => opt.MapFrom(c => c.Counties.
					Select(x => new CountyDTO
					{
						Name = x.Name,
						Id = x.Id,
						Districts = x.Districts.
							Select(d => new KeyValuePairDTO { Id = d.Id, Name = d.Name }).ToList()
					})));

			CreateMap<WorkerType, KeyValuePairDTO>()
				.ForMember(kv => kv.Name, opt => opt.MapFrom(wk => wk.DescriptionWorkerType))
				.ForMember(kv => kv.Id, opt => opt.MapFrom(wk => wk.Id));

			CreateMap<Person, PersonDTO>().ReverseMap();
			//.ForMember(ar => ar.Id, opt => opt.MapFrom(pe => pe.Id))
			//.ForMember(ar => ar.Name, opt => opt.MapFrom(pe => pe.Name))
			//.ForMember(ar => ar.LastName, opt => opt.MapFrom(pe => pe.LastName))
			//.ForMember(ar => ar.SecondLastName, opt => opt.MapFrom(pe => pe.SecondLastName))
			//.ForMember(ar => ar.BirthDay, opt => opt.MapFrom(pe => pe.BirthDay))
			//.ForMember(ar => ar.Email, opt => opt.MapFrom(pe => pe.Email))
			//.ForMember(ar => ar.Phone, opt => opt.MapFrom(pe => pe.Phone))
			//.ForMember(ar => ar.PersonTypeId, opt => opt.MapFrom(pe => pe.PersonTypeId));

			

			CreateMap<JobInformation, JobInformationDTO>().ReverseMap();
			//.ForMember(jid => jid.CompanyName, opt => opt.MapFrom(jo => jo.CompanyName))
			//.ForMember(jid => jid.ActualPosition, opt => opt.MapFrom(jo => jo.ActualPosition))
			//.ForMember(jid => jid.AnualSalary, opt => opt.MapFrom(jo => jo.CompanyName))
			//.ForMember(jid => jid.Phone, opt => opt.MapFrom(jo => jo.Phone))
			//.ForMember(jid => jid.AddressCompany, opt => opt.MapFrom(jo => jo.AddressCompany))
			//.ForMember(jid => jid.CompanyName, opt => opt.MapFrom(jo => jo.CompanyName))
			//.ForMember(jid => jid.WorkerTypeId, opt => opt.MapFrom(jo => jo.WorkerTypeId));

			CreateMap<MarriageInformation, MarriageInformationDTO>().ReverseMap();
			//.ForMember(mid => mid.MaritalStateId, opt => opt.MapFrom(mi => mi.MaritalStateId))
			//.ForMember(mid => mid.RoomHouseId, opt => opt.MapFrom(mi => mi.RoomHouseId))
			//.ForMember(mid => mid.MarriageDate, opt => opt.MapFrom(mi => mi.MarriageDate));

			CreateMap<AdoptionRequestDTO, AdoptionProcess>()
				.ForMember(ard => ard.ProcessDescripction, opt => opt.MapFrom(ap => ap.ProcessDescripction))
				.ForMember(ard => ard.AllDocuments, opt => opt.MapFrom(ap => ap.AllDocuments))
				.ForMember(ard => ard.StateFileId, opt => opt.MapFrom(ap => ap.StateFileId))
				.ForMember(ard => ard.ParentsInterview, opt => opt.MapFrom(ap => ap.ParentsInterview))
				.ForMember(ard => ard.FamilyVisit, opt => opt.MapFrom(ap => ap.FamilyVisit))
				.ForMember(ard => ard.IDKid, opt => opt.MapFrom(ap => ap.IDKid))
				.ForMember(ard => ard.MarriageInformation, opt => opt.MapFrom(ma => ma.MarriageInformation));


		}
	}
}