using Adoption.Contract.DataContract;
using Adoption.Contract.Interface;
using Adoption.Core.Interface;
using Adoption.Core.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Adoption.Contract
{
	// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "UserServices" en el código, en svc y en el archivo de configuración a la vez.
	// NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione UserServices.svc o UserServices.svc.cs en el Explorador de soluciones e inicie la depuración.
	public class UserServices : IUserServices
	{
		private readonly IUnitOfWork uow;

		public UserServices(IUnitOfWork uow)
		{
			this.uow = uow;
		}

		public UserDTO Login(string email, string password)
		{
			var result = this.uow.User.Get(x => x.Email == email && x.Password == password);

			if (result is null)
				throw new WebFaultException(HttpStatusCode.Unauthorized);

			return Mapper.Map<UserDTO>(result);
		}

		public UserDTO Register(UserDTO user)
		{
			var User = Mapper.Map<UserDTO, User>(user);
			this.uow.User.Add(User);
			this.uow.SaveChanges();

			user.Password = null;


			return user;
		}
	}
}
