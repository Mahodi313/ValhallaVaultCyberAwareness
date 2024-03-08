using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ValhallaVaultCyberAwareness.App.Services
{
    public interface IAuthService
    {
        public Task<ClaimsPrincipal> GetCurrentUserDataAsync();
    }
}
