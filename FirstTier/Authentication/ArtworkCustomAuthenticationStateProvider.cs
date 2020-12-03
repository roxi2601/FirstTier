using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

namespace FirstTier.Authentication
{
    public class ArtworkCustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}