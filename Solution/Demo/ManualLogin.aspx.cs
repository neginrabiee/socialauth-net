﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Brickred.SocialAuth.NET.Core.BusinessObjects;

namespace Brickred.SocialAuth.NET.Demo
{
    public partial class ManualLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SocialAuthUser objUser = new SocialAuthUser();
            
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            //PROVIDER_TYPE selectedProvider = (PROVIDER_TYPE)Enum.Parse(typeof(PROVIDER_TYPE), ((Button)sender).Text.ToUpper());
            //SocialAuthUser.Connect(selectedProvider, SCOPE_LEVEL.MINIMUN, "Welcome.aspx");

            //We need to get user's selected provider enumerator.
            PROVIDER_TYPE selectedProvider = (PROVIDER_TYPE)Enum.Parse(typeof(PROVIDER_TYPE), ((Button)sender).Text.ToUpper());

            //Initialize User
            SocialAuthUser objUser = new SocialAuthUser(selectedProvider);

            //Call Login
            objUser.Login();
            //Login method also accepts a parameter for URL to which user should be redirected after login. If not specified, 
            //automatically defaultUrl as set in Web.Config will be picked for redirection.
        }

        
    }
}