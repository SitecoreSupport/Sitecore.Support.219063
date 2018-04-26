using Sitecore.Analytics.Commons;
using Sitecore.Cloud.Xdb;
using Sitecore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.Cloud.Xdb
{
  public class CloudBasedTransportFactory : ApiKeyHttpTransportFactory
  {
    public CloudBasedTransportFactory(string timeout, string serviceUrl, string certificateThumbprint, bool requireHttps, string connectionStringName, string headerName, string minimalApiKeyLength) : base(serviceUrl, timeout, requireHttps, connectionStringName, headerName, minimalApiKeyLength)
    {
      SslCertificateValidationListener.Initialize(certificateThumbprint);
    }
  }
}