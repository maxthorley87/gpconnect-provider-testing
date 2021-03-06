﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using GPConnect.Provider.AcceptanceTests.Constants;
using GPConnect.Provider.AcceptanceTests.Extensions;
using GPConnect.Provider.AcceptanceTests.Logger;
using Microsoft.IdentityModel.Tokens;

// ReSharper disable ClassNeverInstantiated.Global

namespace GPConnect.Provider.AcceptanceTests.Helpers
{
    public class JwtHelper
    {
        private const string Bearer = "Bearer ";
        private const int MaxExpiryTimeInMinutes = 5;

        public DateTime? CreationTime { get; set; }
        public DateTime? ExpiryTime { get; set; }
        public string ReasonForRequest { get; set; }
        public string AuthTokenURL { get; set; }
        public string RequestingDevice { get; set; }
        public string RequestingOrganization { get; set; }
        public string RequestingPractitioner { get; set; }
        public string RequestingPractitionerId { get; set; }
        public string RequestedScope { get; set; }
        public string RequestedPatientNHSNumber { get; set; }
        public string RequestedOrganizationODSCode { get; set; }
        public string RequestingSystemUrl { get; set; }

        private JwtHelper()
        {
            Log.WriteLine("JwtHelper() Constructor");
            SetDefaultValues();
        }

        public void SetDefaultValues()
        {
            CreationTime = DateTime.UtcNow;
            ExpiryTime = CreationTime.Value.AddMinutes(MaxExpiryTimeInMinutes);
            ReasonForRequest = JwtConst.Values.kDirectCare;
            AuthTokenURL = JwtConst.Values.kAuthTokenURL;
            RequestingDevice = FhirHelper.GetDefaultDevice().ToJson();
            RequestingOrganization = FhirHelper.GetDefaultOrganization().ToJson();
            RequestingPractitionerId = FhirHelper.GetDefaultPractitioner().Id;
            RequestingPractitioner = FhirHelper.GetDefaultPractitioner().ToJson();
            RequestedScope = JwtConst.Scope.kOrganizationRead;
            // TODO Check We're Using The Correct Scope For Metadata vs. GetCareRecord
            RequestedPatientNHSNumber = null;
            // TODO Move Dummy Data Out Into App.Config Or Somewhere Else
            RequestedOrganizationODSCode = "OrgODSCode0001";
            RequestingSystemUrl = "https://ConsumerSystemURL";
        }

        private static string BuildEncodedHeader()
        {
            return new JwtHeader().Base64UrlEncode();
        }

        private string BuildEncodedPayload()
        {
            return BuildPayload().Base64UrlEncode();
        }

        private JwtPayload BuildPayload()
        {

            var claims = new List<Claim>();

            if (RequestingSystemUrl != null)
                claims.Add(new Claim(JwtConst.Claims.kRequestingSystemUrl, RequestingSystemUrl, ClaimValueTypes.String));
            if (RequestingPractitionerId != null)
                claims.Add(new Claim(JwtConst.Claims.kPractitionerId, RequestingPractitionerId, ClaimValueTypes.String));
            if (AuthTokenURL != null)
                claims.Add(new Claim(JwtConst.Claims.kAuthTokenURL, AuthTokenURL, ClaimValueTypes.String));
            if (ExpiryTime != null)
                claims.Add(new Claim(JwtConst.Claims.kExpiryTime, EpochTime.GetIntDate(ExpiryTime.Value).ToString(), ClaimValueTypes.Integer64));
            if (CreationTime != null)
                claims.Add(new Claim(JwtConst.Claims.kCreationTime, EpochTime.GetIntDate(CreationTime.Value).ToString(), ClaimValueTypes.Integer64));
            if (ReasonForRequest != null)
                claims.Add(new Claim(JwtConst.Claims.kReasonForRequest, ReasonForRequest, ClaimValueTypes.String));
            if (RequestingDevice != null)
                claims.Add(new Claim(JwtConst.Claims.kRequestingDevice, RequestingDevice, JsonClaimValueTypes.Json));
            if (RequestingOrganization != null)
                claims.Add(new Claim(JwtConst.Claims.kRequestingOrganization, RequestingOrganization, JsonClaimValueTypes.Json));
            if (RequestingPractitioner != null)
                claims.Add(new Claim(JwtConst.Claims.kRequestingPractitioner, RequestingPractitioner, JsonClaimValueTypes.Json));
            if (RequestedScope != null)
                claims.Add(new Claim(JwtConst.Claims.kRequestedScope, RequestedScope, ClaimValueTypes.String));

            if (RequestedPatientNHSNumber != null)
            {
                claims.Add(new Claim(JwtConst.Claims.kRequestedRecord, FhirHelper.GetDefaultPatient(RequestedPatientNHSNumber).ToJson(), JsonClaimValueTypes.Json));
            }
            else if (RequestedOrganizationODSCode != null)
            {
                claims.Add(new Claim(JwtConst.Claims.kRequestedRecord, FhirHelper.GetDefaultOrganization(RequestedOrganizationODSCode).ToJson(), JsonClaimValueTypes.Json));
            }

            return new JwtPayload(claims);
        }

        public string GetBearerTokenWithoutEncoding()
        {
            return Bearer + BuildBearerTokenOrgResourceWithoutEncoding();
        }

        private string BuildBearerTokenOrgResourceWithoutEncoding()
        {
            return new JwtHeader().SerializeToJson() + "." + BuildPayload().SerializeToJson() + ".";
        }

        public string GetBearerToken()
        {
            return Bearer + BuildBearerTokenOrgResource();
        }

        private string BuildBearerTokenOrgResource()
        {
            return BuildEncodedHeader() + "." + BuildEncodedPayload() + ".";
        }

        public void SetExpiryTimeInSeconds(double seconds)
        {
            Debug.Assert(CreationTime != null, "_jwtCreationTime != null");
            ExpiryTime = CreationTime.Value.AddSeconds(seconds);
        }

        public void SetCreationTimeSeconds(double seconds)
        {
            CreationTime = DateTime.UtcNow.AddSeconds(seconds);
            ExpiryTime = CreationTime.Value.AddMinutes(MaxExpiryTimeInMinutes);
        }

        public void SetRequestingPractitioner(string practitionerId, string practitionerJson)
        {
            // TODO Make The RequestingPractitionerId Use The Business Identifier And Not The Logical Identifier 
            RequestingPractitionerId = practitionerId;
            RequestingPractitioner = practitionerJson;
        }
    }
}
