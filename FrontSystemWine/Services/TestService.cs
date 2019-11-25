using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace FrontSystemWine.Services
{
    public class TestService
    {
        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        private readonly UserManager<IdentityUser> _userManager;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private AuthenticationState _authenticationState;

        public TestService(UserManager<IdentityUser> userManager, AuthenticationStateProvider authenticationStateProvider)
        {            
            _userManager = userManager;
            _authenticationStateProvider = authenticationStateProvider;
        }

        private Task<IdentityUser> GetCurrentUserAsync() => _userManager.FindByNameAsync("thales.areis@gmail.com");
        
        public string Votar()
        {

            IdentityUser usr = GetCurrentUserAsync().Result;

            return usr.Id;
        }
    }
}
