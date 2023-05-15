Feature: Shopping 
	Adding random items to my cart
	
Scenario: Successfully add items in the cart
	Given I add four random items to my cart
	And I view my cart
	Then I find total four items listed in my cart
	When I search for lowest price item
	And I am able to remove the lowest price item from my cart
	Then I am able to verify three items in my cart