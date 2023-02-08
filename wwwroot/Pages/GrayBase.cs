using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAuthApp.Pages
{
    public class GrayBase : ComponentBase
    {
        protected string AccessToken = null;

        protected void GetMessages()
        {
            this.SignInProcess();
        }

        private void SignInProcess()
        {
            if (string.IsNullOrEmpty(this.AccessToken))
            {
                _ = this.GetAccessToken(true);
            }
        }

        private string GetAccessToken(bool promptConsent = false)
        {
            if (promptConsent)
            {
                AccessToken = "test token";
                // NavigationManager.NavigateTo("auth.start.html");
            }
            return "temp token";
        }
    }
}
