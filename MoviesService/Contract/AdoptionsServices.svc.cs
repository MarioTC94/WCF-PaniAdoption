using Adoption.Contract;
using Adoption.Contract.DataContract;
using Adoption.Core.Interface;
using Adoption.Core.Models;
using System;
using System.Collections.Generic;

namespace Adoption.Contract
{
	public class AdoptionsServices : IAdoptionServices
	{
		private readonly IUnitOfWork uow;

		public AdoptionsServices(IUnitOfWork uow)
		{
			this.uow = uow;
		}

		public AdoptionProcess AddAdoptionProcess(AdoptionRequestDTO adoptionRequest)
		{
			var adoption = AutoMapper.Mapper.Map<AdoptionProcess>(adoptionRequest);
			return adoption;

		}

		public void RemoveAdoptionProcess(int id)
		{
			throw new System.NotImplementedException();
		}

		public AdoptionProcess TryMapping()
		{
			var adoption = new AdoptionRequestDTO
			{
				AllDocuments = true,
				FamilyVisit = true,
				IDKid = "4536363",
				ParentsInterview = true,
				ProcessDescripction = "hola",
				StateFileId = 1,
				MarriageInformation = new MarriageInformationDTO
				{

					MaritalStateId = 1,
					RoomHouseId = 1,
					MarriageDate = DateTime.Now,
					Father = new PersonDTO
					{

						Name = "Pedro",
						LastName = "Torres",
						SecondLastName = "Castillo",
						BirthDay = DateTime.Now,
						Email = "fdkgdkg@hotmail.com",
						Id = "3435363",
						Phone = "4353503",
						PersonTypeId = 1,
						JobInformation = new JobInformationDTO
						{
							ActualPosition = "holi",
							Phone = "535352",
							AddressCompany = "china",
							AnualSalary = 100,
							CompanyName = "xbox",
							WorkerTypeId = 1
						}
					},
					Mother = new PersonDTO
					{

						Name = "Juanita",
						LastName = "Torres",
						SecondLastName = "Castillo",
						BirthDay = DateTime.Now,
						Email = "fdkgdkg@hotmail.com",
						Id = "34353632",
						Phone = "43535030",
						PersonTypeId = 2,
						JobInformation = new JobInformationDTO
						{
							ActualPosition = "holiwis",
							Phone = "535353535",
							AddressCompany = "china",
							AnualSalary = 100,
							CompanyName = "xbox",
							WorkerTypeId = 1
						}
					}
				}
			};
			return AutoMapper.Mapper.Map<AdoptionProcess>(adoption);
		}

		public void UptadeAdoptionProcess(int id, AdoptionRequestDTO adoptionRequest)
		{
			throw new System.NotImplementedException();
		}
	}
}
