using GymManager.Core.MembershipTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.MembershipTypes
{
    public class MembershipTypesAppServices : IMembershipTypes
    {
        private static List<MembershipType> MembershipTypes = new List<MembershipType>();

        public int AddMembershipType(MembershipType membership)
        {
            membership.Id = new Random().Next();

            MembershipTypes.Add(membership);
        
            return membership.Id;
        }

       
        public void DeleteMembershipType(int membershipId)
        {
            var m = MembershipTypes.Where(x => x.Id == membershipId).FirstOrDefault();
            MembershipTypes.Remove(m);
        }

        public void EditMembershipType(MembershipType membership)
        {
            var m = MembershipTypes.Where(x => x.Id == membership.Id).FirstOrDefault();
            m.Duration = membership.Duration;
            m.CreateOn = DateTime.Now;
            m.Cost = membership.Cost;
            m.Name = membership.Name;

        }

        public MembershipType GetMembershipType(int membershipId)
        {
            Console.WriteLine(membershipId);
            var m = MembershipTypes.Where(x => x.Id == membershipId).FirstOrDefault();
            return m;
        }

        public List<MembershipType> GetMembershipTypes()
        {
            return MembershipTypes;
        }
    }

}
