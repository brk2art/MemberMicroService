using EuropeAndFuture.Core.DataAccess;
using System;

namespace MemberRegistration.Entities
{
    public class Member:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
    }
}
