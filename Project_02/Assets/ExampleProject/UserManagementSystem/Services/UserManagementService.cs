using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using uFrame.Kernel;
using uFrame.IOC;
using UniRx;
using UnityEngine;
using uFrame.MVVM;

namespace uFrame.ExampleProject
{
    public class UserManagementService : UserManagementServiceBase
    {

        [Inject("LocalUser")] public UserViewModel LocalUser;

        public override void Setup()
        {
            base.Setup();
            LocalUser.AuthorizationState = AuthorizationState.Unauthorized;
            LocalUser.Username = "%unknow%";
        }

        public void AuthorizeLocalUser(string Username, string Password)
        {
            if (Username == "uframe" && Password == "uframe")
            {
                Debug.Log("authorized in service");
                LocalUser.AuthorizationState = AuthorizationState.Authorized;
                LocalUser.Username = Username;
               
            }
        }


    }
}
