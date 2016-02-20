using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        
        public string GetInfo()
        {
            StringBuilder mySB = new StringBuilder("");
            mySB.AppendLine(string.Format("Is authenticated: {0}", ServiceSecurityContext.Current.PrimaryIdentity.IsAuthenticated));

            mySB.AppendLine(string.Format("Authentication Type: {0}", ServiceSecurityContext.Current.PrimaryIdentity.AuthenticationType));

            mySB.AppendLine(string.Format("Authentication Name: {0}", ServiceSecurityContext.Current.PrimaryIdentity.Name));

            return mySB.ToString();
        }
    }
}
