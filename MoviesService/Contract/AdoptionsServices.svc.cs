using Adoption.Contract.DataContract;
using Adoption.Core.Interface;
using Adoption.Core.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Net;
using System.ServiceModel.Web;

namespace Adoption.Contract
{
	public class AdoptionsServices : IAdoptionServices
	{
		private readonly IUnitOfWork uow;

		public AdoptionsServices(IUnitOfWork uow)
		{
			this.uow = uow;
		}

		public AdoptionRequestDTO AddAdoptionProcess(SaveAdoptionRequestDTO adoptionRequest)
		{
			var adoption = Mapper.Map<SaveAdoptionRequestDTO, AdoptionProcess>(adoptionRequest);
			this.uow.AdoptionProcess.Add(adoption);
			this.uow.SaveChanges();

			adoption = uow.AdoptionProcess.GetAdoptionWithRelatives(adoption.Id);
			var result = Mapper.Map<AdoptionRequestDTO>(adoption);

			return result;
		}

		public AdoptionRequestDTO GetadoptionProcess(int id)
		{
			var adoption = uow.AdoptionProcess.GetAdoptionWithRelatives(id);

			if (adoption is null)
				throw new WebFaultException(HttpStatusCode.NotFound);

			return Mapper.Map<AdoptionRequestDTO>(adoption);
		}

		public ICollection<AdoptionRequestDTO> GetAllAdoptionProcess()
		{
			var adoptions = uow.AdoptionProcess.GetAdoptionWithRelatives();
			var result =  Mapper.Map<ICollection<AdoptionRequestDTO>>(adoptions);
			return result;
		}

		public int RemoveAdoptionProcess(int id)
		{
			var adoptionProcess = this.uow.AdoptionProcess.GetAdoptionWithRelatives(id);

			if (adoptionProcess is null)
				throw new WebFaultException(HttpStatusCode.NotFound);

			uow.JobInformation.RemoveRange(adoptionProcess.MarriageInformation.Mother.JobInformation);
			uow.JobInformation.RemoveRange(adoptionProcess.MarriageInformation.Father.JobInformation);
			uow.Person.Remove(adoptionProcess.MarriageInformation.Mother);
			uow.Person.Remove(adoptionProcess.MarriageInformation.Father);
			uow.MarriageInformation.Remove(adoptionProcess.MarriageInformation);
			uow.AdoptionProcess.Remove(adoptionProcess);

			uow.SaveChanges();
			List<AdoptionProcess> list = new List<AdoptionProcess>();

			return id;
		}

		public AdoptionRequestDTO UpdateAdoptionProcess(int id, SaveAdoptionRequestDTO adoptionRequest)
		{
			var adoption = uow.AdoptionProcess.GetAdoptionWithRelatives(id);


			if (adoption is null)
				throw new WebFaultException(HttpStatusCode.NotFound);

			Mapper.Map<SaveAdoptionRequestDTO, AdoptionProcess>(adoptionRequest, adoption);
			uow.SaveChanges();

			adoption = uow.AdoptionProcess.GetAdoptionWithRelatives(adoption.Id);
			return Mapper.Map<AdoptionProcess, AdoptionRequestDTO>(adoption);
		}
	}
}
