Feature: Search
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: User can search for a product and add it to the cart
    Given user enters a DRESS search term
    And user submits the search
    And opens first product from the list
    When user clicks on add to cart button
    And user proceeds to checkout
    Then cart page is opened
