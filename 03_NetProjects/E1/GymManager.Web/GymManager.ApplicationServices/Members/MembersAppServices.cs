using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Members
{
    public class MembersAppServices : IMembersAppServices
    {
        public List<Member> GetMembers()
        {
            List<Member> members = new List<Member>();

            members.Add(new Member
            {
                Name = "Sofia",
                LastName = "Carrillo",
                BirthDay = new DateTime(2001, 4, 22),
                AllowNewsletter = true,
                CityId = 1,
                Email = "sofi@gmail.com"
            });

            members.Add(new Member
            {
                Name = "Dennis",
                LastName = "Yam",
                BirthDay = new DateTime(2001, 10, 12),
                AllowNewsletter = true,
                CityId = 2,
                Email = "dennis@gmail.com"
            });

            members.Add(new Member
            {
                Name = "Ariatne",
                LastName = "Moo",
                BirthDay = new DateTime(2001, 1, 18),
                AllowNewsletter = true,
                CityId = 3,
                Email = "ari@gmail.com"
            });

            members.Add(new Member
            {
                Name = "Cesar",
                LastName = "Carrillo",
                BirthDay = new DateTime(2003, 2, 8),
                AllowNewsletter = true,
                CityId = 4,
                Email = "cesar@gmail.com"
            });

            members.Add(new Member
            {
                Name = "Maria",
                LastName = "Ek",
                BirthDay = new DateTime(2000, 10, 12),
                AllowNewsletter = true,
                CityId = 5,
                Email = "maria@gmail.com"
            });

            members.Add(new Member
            {
                Name = "Angel",
                LastName = "Moo",
                BirthDay = new DateTime(2001, 12, 18),
                AllowNewsletter = true,
                CityId = 6,
                Email = "angel@gmail.com"
            });

            return members;
        }
    }
}
