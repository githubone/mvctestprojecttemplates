Feature: GuineaPig
   In order to test SauceLabs features there is a GuineaPig test page.
 
@Browser:IE
Scenario: Add comments
   Given I navigated to guinea-pig
   And I have entered 'This is not a comment' into the commentbox
   When I press 'send'
   Then my comment 'This is not a comment' is displayed on the screen