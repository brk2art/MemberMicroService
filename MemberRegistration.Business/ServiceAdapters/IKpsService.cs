using MemberRegistration.Entities;

namespace MemberRegistration.Business.ServiceAdapters
{
    public interface IKpsService
    {
        bool ValidateUser(Member member);
    }
}
