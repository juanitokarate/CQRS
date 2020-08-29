using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.CQRSqueries.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }
        public int Yearsold
        {
            get
            {
                int yearsOld = DateTime.Today.Year - Birthdate.Year;
                return yearsOld;
            }
        }
        public UserDTO()
        {

        }

        public UserDTO(int id, string username, string password, DateTime birthdate)
        {
            Id = id;
            Username = username;
            Password = password;
            Birthdate = birthdate;
        }
    }
}
