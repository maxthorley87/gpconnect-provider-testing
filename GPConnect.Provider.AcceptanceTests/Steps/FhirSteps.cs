﻿using TechTalk.SpecFlow;
using GPConnect.Provider.AcceptanceTests.tools;

namespace GPConnect.Provider.AcceptanceTests.Steps
{

    [Binding]
    public class FhirSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private HeaderController headerController;
        private JwtHelper jwtHelper;

        public FhirSteps(ScenarioContext scenarioContext)
        {
            this._scenarioContext = scenarioContext;
            headerController = HeaderController.Instance;
            jwtHelper = JwtHelper.Instance;
        }
        
    }
}
