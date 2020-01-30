using EuropeAndFuture.Core.DataAccess.EntityFramework;
using MemberRegistration.DataAccess.Abstract;
using MemberRegistration.Entities;

namespace MemberRegistration.DataAccess.Concrete.EntityFramework
{
    public class EfMemberDal : EfEntityRepositoryBase<Member, MembershipContext>, IMemberDal
    {

    }
}
