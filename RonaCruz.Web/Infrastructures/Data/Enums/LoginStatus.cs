using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RonaCruz.Web.Infrastructures.Data.Enums
{
    public enum LoginStatus
    {
        Unverified,
        Active,
        Locked,
        NeedsToChangePassword
    }
}