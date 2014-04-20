@PostCodeRestaurantSearch
Feature: SearchRestaurants
	In order to find restaurants
	As a  user of JustEatRAPPS site
	I want to search for available restaurants by post code

Background: 
Given I am on JustEatRAPPS site

Scenario Outline: Invalid PostCode
When I enter an invalid postcode of <postCode>
And click the search icon
Then the validation error message should read <message>

Examples:
| postCode | message |
| empty | Post Code required |
| se789 | Post Code is invalid |
