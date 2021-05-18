using CheeprToKeepr.Models;
using CheeprToKeepr.Models.ViewModels;
using CheeprToKeepr.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Infrastructure
{
    public class CheeprToKeeprService : ICheeprToKeeprService
    {
        private readonly ApplicationDbContext _db;
        public CheeprToKeeprService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<OwnerViewModel> GetOwnerList()
        {
            var owners = (from owner in _db.Users
                          join ownerRoles in _db.UserRoles on owner.Id equals ownerRoles.UserId
                          join roles in _db.Roles.Where(o=>o.Name==Helper.Owner) on ownerRoles.RoleId equals roles.Id
                          select new OwnerViewModel
                          {
                              Id = owner.Id,
                              Name = owner.Name
                          }
                          ).ToList();
            return owners;
        }

        public List<AdminViewModel> GetAdminList()
        {
            var admin = (from owner in _db.Users
                          join ownerRoles in _db.UserRoles on owner.Id equals ownerRoles.UserId
                          join roles in _db.Roles.Where(o => o.Name == Helper.Admin) on ownerRoles.RoleId equals roles.Id
                          select new AdminViewModel
                          {
                              Id = owner.Id,
                              Name = owner.Name
                          }
                          ).ToList();
            return admin;
        }
    }
}
