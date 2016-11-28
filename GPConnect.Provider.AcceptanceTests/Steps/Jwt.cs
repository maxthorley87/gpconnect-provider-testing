﻿using TechTalk.SpecFlow;
using GPConnect.Provider.AcceptanceTests.tools;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace GPConnect.Provider.AcceptanceTests.Steps
{

    [Binding]
    public class Jwt : TechTalk.SpecFlow.Steps
    {
        private readonly ScenarioContext _scenarioContext;
        private HeaderController _headerController;
        private JwtHelper _jwtHelper;

        public Jwt(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _headerController = HeaderController.Instance;
            _jwtHelper = JwtHelper.Instance;
        }


        // JWT configuration steps

        [Given(@"I set the default JWT")]
        public void ISetTheDefaultJWT()
        {
            _jwtHelper.setJwtDefaultValues();
            _headerController.removeHeader("Authorization");
            _headerController.addHeader("Authorization", "Bearer " + _jwtHelper.buildBearerTokenOrgResource());
        }

        [Given(@"I set the default JWT without base64 encoding")]
        public void ISetTheJWTWithoutBase64Encoding()
        {
            _jwtHelper.setJwtDefaultValues();
            _headerController.removeHeader("Authorization");
            _headerController.addHeader("Authorization", "Bearer " + _jwtHelper.buildBearerTokenOrgResourceWithoutEncoding());
        }

        [Given(@"I set the JWT expiry time to ""(.*)"" seconds after creation time")]
        public void ISetTheJWTExpiryTimeToSecondsAfterCreationTime(double expirySeconds)
        {
            _jwtHelper.setJWTExpiryTimeInSeconds(expirySeconds);
            _headerController.removeHeader("Authorization");
            _headerController.addHeader("Authorization", "Bearer " + _jwtHelper.buildBearerTokenOrgResource());
        }
        
        [Given(@"I set the JWT creation time to ""(.*)"" seconds after the current time")]
        public void ISetTheJWTCreationTimeToSecondsAfterTheCurrentTime(double secondsInFuture)
        {
            _jwtHelper.setJWTCreationTimeSeconds(secondsInFuture);
            _headerController.removeHeader("Authorization");
            _headerController.addHeader("Authorization", "Bearer " + _jwtHelper.buildBearerTokenOrgResource());
        }
        
        [Given(@"I set the JWT reason for request to ""(.*)""")]
        public void ISetTheJWTReasonForRequestTo(string reasonForRequest)
        {
            _jwtHelper.setJWTReasonForRequest(reasonForRequest);
            _headerController.removeHeader("Authorization");
            _headerController.addHeader("Authorization", "Bearer " + _jwtHelper.buildBearerTokenOrgResource());
        }

        [Given(@"I set the JWT authorization server token URL to ""(.*)""")]
        public void ISetTheJWTAuthorizationServerTokenTo(string autTokenUrl)
        {
            _jwtHelper.setJWTAuthTokenURL(autTokenUrl);
            _headerController.removeHeader("Authorization");
            _headerController.addHeader("Authorization", "Bearer " + _jwtHelper.buildBearerTokenOrgResource());
        }
        
        [Given(@"I set an invalid JWT requesting device resource")]
        public void ISetAnInvalidJWTRequestingDeviceResource()
        {
            _jwtHelper.setJWTRequestingDevice(_jwtHelper.addInvalidFieldToResourceJson(FhirSerializer.SerializeResourceToJson(_jwtHelper.getDefaultDevice())));
            _headerController.removeHeader("Authorization");
            _headerController.addHeader("Authorization", "Bearer " + _jwtHelper.buildBearerTokenOrgResource());
        }

        [Given(@"I set an invalid JWT requesting organization resource")]
        public void ISetAnInvalidJWTRequestingOrganizationResource()
        {
            _jwtHelper.setJWTRequestingOrganization(_jwtHelper.addInvalidFieldToResourceJson(FhirSerializer.SerializeResourceToJson(_jwtHelper.getDefaultOrganization())));
            _headerController.removeHeader("Authorization");
            _headerController.addHeader("Authorization", "Bearer " + _jwtHelper.buildBearerTokenOrgResource());
        }

        [Given(@"I set JWT requesting organization resource without ODS Code")]
        public void ISetJWTRequestingOrganizaitonResourceWithoutODSCode()
        {
            Organization organization = _jwtHelper.getDefaultOrganization();
            organization.Identifier.Clear();
            organization.Identifier.Add(new Identifier("http://fhir.nhs.net/Id/someOtherCodingSystem", "NoOdsCode"));
            _jwtHelper.setJWTRequestingOrganization(FhirSerializer.SerializeToJson(organization));
            _headerController.removeHeader("Authorization");
            _headerController.addHeader("Authorization", "Bearer " + _jwtHelper.buildBearerTokenOrgResource());
        }

        [Given(@"I set an invalid JWT requesting practitioner resource")]
        public void ISetAnInvalidJWTRequestingPractitionerResource()
        {
            _jwtHelper.setJWTRequestingPractitioner("1", _jwtHelper.addInvalidFieldToResourceJson(FhirSerializer.SerializeResourceToJson(_jwtHelper.getDefaultPractitioner())));
            _headerController.removeHeader("Authorization");
            _headerController.addHeader("Authorization", "Bearer " + _jwtHelper.buildBearerTokenOrgResource());
        }

        [Given(@"I set a JWT requesting practitioner without SDS id")]
        public void ISetAJWTRequestingPractitionerWithoutSDSId()
        {
            Practitioner practitioner = _jwtHelper.getDefaultPractitioner();
            practitioner.Identifier.Clear();
            practitioner.Identifier.Add(new Identifier("http://IdentifierServer/RandomId", "ABC123"));
            _jwtHelper.setJWTRequestingPractitioner("1", FhirSerializer.SerializeToJson(practitioner));
            _headerController.removeHeader("Authorization");
            _headerController.addHeader("Authorization", "Bearer " + _jwtHelper.buildBearerTokenOrgResource());
        }

        [Given(@"I set a JWT requesting practitioner with miss matched user id")]
        public void ISetAJWTRequestingPractitionerWithMissMatchedUserId()
        {
            _jwtHelper.setJWTRequestingPractitioner("2", FhirSerializer.SerializeToJson(_jwtHelper.getDefaultPractitioner()));
            _headerController.removeHeader("Authorization");
            _headerController.addHeader("Authorization", "Bearer " + _jwtHelper.buildBearerTokenOrgResource());
        }

        [Given(@"I set a JWT requesting practitioner with missing name element")]
        public void ISetAJWTRequestingPractitionerWithMissingNameElement()
        {
            Practitioner practitioner = _jwtHelper.getDefaultPractitioner();
            practitioner.Name = null;
            _jwtHelper.setJWTRequestingPractitioner("1", FhirSerializer.SerializeToJson(practitioner));
            _headerController.removeHeader("Authorization");
            _headerController.addHeader("Authorization", "Bearer " + _jwtHelper.buildBearerTokenOrgResource());
        }

        [Given(@"I set a JWT requesting practitioner with missing SDS Job Role")]
        public void ISetAJWTRequestingPractitionerWithMissingSDSJobRole()
        {
            Practitioner practitioner = _jwtHelper.getDefaultPractitioner();
            practitioner.PractitionerRole = _jwtHelper.getPractitionerRoleComponent("http://invalidValueSetServer.nhs.uk", "NonSDSJobRoleName");
            _jwtHelper.setJWTRequestingPractitioner("1", FhirSerializer.SerializeToJson(practitioner));
            _headerController.removeHeader("Authorization");
            _headerController.addHeader("Authorization", "Bearer " + _jwtHelper.buildBearerTokenOrgResource());
        }

        [Given(@"I set the JWT requested scope to ""(.*)""")]
        public void ISetTheJWTRequestedScopeTo(string requestedScope)
        {
            _jwtHelper.setJWTRequestedScope(requestedScope);
            _headerController.removeHeader("Authorization");
            _headerController.addHeader("Authorization", "Bearer " + _jwtHelper.buildBearerTokenOrgResource());
        }

    }
}