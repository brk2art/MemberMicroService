using System;
using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.DependencyResolvers.Ninject;
using MemberRegistration.Entities;

namespace MemberRegistration.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMemberService memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member
            {
                FirstName = "Burak",
                LastName = "Arat",
                DateOfBirth = new DateTime(1992,2,2),
                Email = "burak2arat@gmail.com",
                TcNo = ""
            });
            Console.WriteLine("Eklendi");
            Console.ReadLine();
        }
    }
}
