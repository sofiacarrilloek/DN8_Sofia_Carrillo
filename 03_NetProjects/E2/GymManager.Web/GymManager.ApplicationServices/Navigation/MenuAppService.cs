using GymManager.Core.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Navigation
{
    public class MenuAppService : IMenuAppService
    {
        /* public List<UserMenuItem> GetMenu()
         {
             List<UserMenuItem> menu = new List<UserMenuItem>();
             menu.Add(new UserMenuItem
             {
                 Name = "Home",
                 Order = 0,
                 Url = "/"
             });

             menu.Add(new UserMenuItem
             {
                 Name = "Administration",
                 Order = 1,
                 Url = "#",
                 Items = new List<UserMenuItem>()
                 {
                     new UserMenuItem
                     {
                         Name = "Membership"
                     }
                 }
             });
         }*/
        public List<UserMenuItem> GetMenu()
        {
            throw new NotImplementedException();
        }
    }
}
