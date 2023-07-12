using GymManager.Core.MembershipTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.MembershipTypes
{
    public interface IMembershipTypes
    {
         List<MembershipType> GetMembershipTypes();
        int AddMembershipType(MembershipType membership);

        void DeleteMembershipType(int membershipId);
        

        MembershipType GetMembershipType(int membershipId);

        void EditMembershipType(MembershipType membership);
    }
}
