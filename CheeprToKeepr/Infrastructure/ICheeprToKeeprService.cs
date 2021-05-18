using CheeprToKeepr.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeprToKeepr.Infrastructure
{
    public interface ICheeprToKeeprService
    {
        public List<OwnerViewModel> GetOwnerList();
    }
}
