﻿@http
Feature: Html

Background:
	Given I have the following patient records
		| Id                      | NHSNumber  |
		| patient1                | 9476719931 |
		| patient2                | 9476719974 |
		| patientNotInSystem      | 9999999999 |
		| patientNoSharingConsent | 9476719958 |

Scenario Outline: HTML does not contain disallowed elements
	Given I am using the default server
		And I am performing the "urn:nhs:names:services:gpconnect:fhir:operation:gpc.getcarerecord" interaction
		And I author a request for the "<Code>" care record section for config patient "patient1"
	When I request the FHIR "gpc.getcarerecord" Patient Type operation
	Then the response status code should indicate success
		And the response body should be FHIR JSON
		And the JSON response should be a Bundle resource
		And the html should be valid xhtml
		And the html should not contain "head" tags
		And the html should not contain "body" tags
		And the html should not contain "script" tags
		And the html should not contain "style" tags
		And the html should not contain "iframe" tags
		And the html should not contain "form" tags
		And the html should not contain "a" tags
		And the html should not contain any attributes
	Examples:
		| Code |
		| ADM  |
		| ALL  |
		| CLI  |
		| ENC  |
		| IMM  |
		#| INV  |
		| MED  |
		| OBS  |
		#| PAT  |
		| PRB  |
		#| REF  |
		| SUM  |

Scenario Outline: section headers present
	Given I am using the default server
		And I am performing the "urn:nhs:names:services:gpconnect:fhir:operation:gpc.getcarerecord" interaction
		And I author a request for the "<Code>" care record section for config patient "<Patient>"
	When I request the FHIR "gpc.getcarerecord" Patient Type operation
	Then the response status code should indicate success
		And the response body should be FHIR JSON
		And the JSON response should be a Bundle resource
		And the html should not contain headers in coma seperated list "<Headers>"
	Examples:
		| Patient | Code | Headers |
		| patient1 | ADM  | Administrative Items |
		| patient1 | ALL  | Current Allergies and Adverse Reactions,Historical Allergies and Adverse Reactions |
		| patient1 | CLI  | Clinical Items |
		| patient1 | ENC  | Encounters |
		| patient1 | IMM  | Immunisations |
		#| patient1 | INV | Investigations |
		| patient1 | MED  | Current Medication Issues,Current Repeat Medications,Past Medications |
		| patient1 | OBS  | Observations |
		#| patient1 | PAT |  |
		| patient1 | PRB  | Active Problems and Issues,Inactive Problems and Issues |
		#| patient1 | REF | Referrals |
		| patient1 | SUM  | Active Problems and Issues,Current Medication Issues,Current Repeat Medications,Current Allergies and Adverse Reactions,Encounters |
	
	# NEED TO EXPAND TEST TO PATIENT WITH NO RETURNED DETAILS AND PATIENT WITH SOME SECTIONS AND ONLY CURRENT OR PAST MEDICATIONS, ONLY HISTORICAL ALLERGIES ETC


@ignore
Scenario: content table headers present

@ignore
Scenario: filtered sections should contain date range section banner

@ignore @Manual
Scenario: System does not support section html response where appropriate