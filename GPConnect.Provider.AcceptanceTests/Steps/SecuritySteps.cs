﻿using GPConnect.Provider.AcceptanceTests.Context;
using GPConnect.Provider.AcceptanceTests.Helpers;
using GPConnect.Provider.AcceptanceTests.Logger;
using TechTalk.SpecFlow;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable ClassNeverInstantiated.Global

namespace GPConnect.Provider.AcceptanceTests.Steps
{
    [Binding]
    public class SecuritySteps : TechTalk.SpecFlow.Steps
    {
        private readonly SecurityContext SecurityContext;

        // Constructor

        public SecuritySteps(SecurityContext securityContext)
        {
            Log.WriteLine("SecuritySteps() Constructor");
            SecurityContext = securityContext;
        }

        // Before Scenario

        [BeforeScenario(Order = 2)]
        public void LoadAppConfig()
        {
            SecurityContext.LoadAppConfig();
        }

        [BeforeScenario(Order = 4)]
        public void DoNotValidateServerCertificate()
        {
            SecurityHelper.DoNotValidateServerCertificate();
        }

        // Security Configuration Steps

        [Given(@"I do not want to verify the server certificate")]
        public void IDoNotWantToVerifyTheServerCertificate()
        {
            SecurityContext.ValidateServerCert = false;
        }

        [Given(@"I do want to verify the server certificate")]
        public void IDoWantToVerifyTheServerCertificate()
        {
            SecurityContext.ValidateServerCert = true;
        }

        [Given(@"I am not using a client certificate")]
        public void IAmNotUsingAClientCertificate()
        {
            SecurityContext.SendClientCert = false;
        }

        [Given(@"I am using client certificate with thumbprint ""(.*)""")]
        public void IAmUsingClientCertificateWithThumbprint(string thumbPrint)
        {
            SecurityContext.ClientCertThumbPrint = thumbPrint;
            SecurityContext.SendClientCert = true;
            Given(@"I configure server certificate and ssl");
        }

        [Given(@"I am using an invalid client certificate")]
        public void IAmUsingAnInvalidClientCertificate()
        {
            SecurityContext.ClientCertThumbPrint = AppSettingsHelper.ClientInvalidCertThumbPrint;
            SecurityContext.SendClientCert = true;
            Given(@"I configure server certificate and ssl");
        }

        [Given(@"I am using an expired client certificate")]
        public void IAmUsingAnExpiredClientCertificate()
        {
            SecurityContext.ClientCertThumbPrint = AppSettingsHelper.ClientExpiredCertThumbPrint;
            SecurityContext.SendClientCert = true;
            Given(@"I configure server certificate and ssl");
        }

        [Given(@"I am using TLS Connection")]
        public void IAmUsingTLSConnection()
        {
            SecurityContext.UseTLS = true;
        }

        [Given(@"I am not using TLS Connection")]
        public void IAmNotUsingTLSConnection()
        {
            SecurityContext.UseTLS = false;
            Given(@"I do not want to verify the server certificate");
            And(@"I am not using a client certificate");
        }

        [Given(@"I configure server certificate and ssl")]
        public void IConfigureServerCertificatesAndSsl()
        {
            // Setup The Client Certificate
            if (SecurityContext.SendClientCert)
            {
                SecurityContext.ClientCert = SecurityHelper.GetCertificateByClientThumbPrint(SecurityContext.ClientCertThumbPrint);
            }

            // Setup The Server Certificate Validation (If Required)
            if (SecurityContext.ValidateServerCert)
            {
                SecurityHelper.ValidateServerCertificate();
            }
            else
            {
                SecurityHelper.DoNotValidateServerCertificate();
            }
        }
    }
}
