using RonaCruz.Web.Infrastructures.Data.Helpers;
using RonaCruz.Web.Infrastructures.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RonaCruz.Web.ViewModels
{
    public class IndexViewModel
    {
        public Page<User> Users { get; set; }
    }
}