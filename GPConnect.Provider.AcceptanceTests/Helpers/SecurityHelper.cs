﻿using System;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace GPConnect.Provider.AcceptanceTests.Helpers
{
    static class SecurityHelper
    {
        public static X509Certificate2 GetCertificateByClientThumbPrint(string clientCertThumbPrint)
        {
            var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            try
            {
                store.Open(OpenFlags.ReadOnly);
                var signingCert = store.Certificates.Find(X509FindType.FindByThumbprint, clientCertThumbPrint, false);
                if (signingCert.Count != 1)
                {
                    throw new FileNotFoundException(string.Format("Cert with thumbprint: '{0}' not found in local machine cert store.", clientCertThumbPrint));
                }
                Console.WriteLine("Client Certificate Found = " + signingCert[0]);
                return signingCert[0];
            }
            finally
            {
                store.Close();
            }
        }

        public static void ValidateServerCertificate()
        {
            ServicePointManager.ServerCertificateValidationCallback =
                (sender, cert, chain, error) =>
                {
                    var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                    bool returnValue;
                    try
                    {
                        store.Open(OpenFlags.ReadOnly);
                        // TODO Fix The Validation Of The Server Certificate
                        returnValue = store.Certificates.Contains(cert);
                    }
                    finally
                    {
                        store.Close();
                    }
                    Console.WriteLine(returnValue);
                    return returnValue;
                };
            ServicePointManager.MaxServicePointIdleTime = 0;
            Console.WriteLine("Setup The Server Certificate Callback To Validate The Server Certificate.");
        }

        public static void ForceServerCertificateToValidate()
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            ServicePointManager.MaxServicePointIdleTime = 0;
            Console.WriteLine("Force The Server Certificate Callback To Always Be True.");
        }

        public static void DoNotValidateServerCertificate()
        {
            ServicePointManager.ServerCertificateValidationCallback = null;
            ServicePointManager.MaxServicePointIdleTime = 0;
            Console.WriteLine("Reset The Server Certificate Callback.");
        }
    }
}