using CQRS.CQRSqueries.DTOs;
using CQRS.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.CQRSqueries
{
    public interface IUserQueryService
    {
        Task<IEnumerable<UserDTO>> GetAll();
        Task<UserDTO> GetById(int id);
    }
    public class UserQueryService : IUserQueryService
    {
        private readonly DBContext db;

        public UserQueryService(DBContext db)
        {
            this.db = db;
        }
        public async Task<IEnumerable<UserDTO>> GetAll()
        {
            var data = DBContext.Users;
            var userDTO = data.Select
                (
                user => new UserDTO(user.Id, user.Username, user.Password, user.Birthdate)
                );
            return userDTO;
        }

        public async Task<UserDTO> GetById(int id)
        {
            var us = DBContext.Users.FirstOrDefault
                (
                user => user.Id == id
                );
            var dataDTO = new UserDTO(us.Id, us.Username, us.Password, us.Birthdate);
            return dataDTO;
        }
    }
}
