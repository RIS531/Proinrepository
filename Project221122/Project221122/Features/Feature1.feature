Feature: TMFeature

As a Turnup Portal Admin
I would like to create,edit and delete Time Material Records
so that I can manage employees' time and material successfully.


Scenario: creat time and material record with valid details
	Given I logged into turnup portal successfully
	When I navigate to Time and material Page
	And  I create new Time and Material Record
	Then Record should be created successfully

Scenario Outline:Edit existing time record with valid details
   Given I logged into turnup portal successfully
   When  I navigate to Time and material Page
   And  I updated '<Description>', '<Code>', '<Price>' on an existing Time record
   Then The record should have the updated '<Description>', '<Code>', '<Price>'
 Examples:   
  | Description | Code    | Price |
  | November    | Sunday  | $50.00    |
  | December    | Monday  | $20.00    |
  | January     | Tuesday | $30.00    |
