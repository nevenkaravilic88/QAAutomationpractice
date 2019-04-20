Feature: MyAccount
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@myAccount
Scenario: User can log in
	Given user opens sign in page
	And enters cirrect credentials
	When user submits the login form
	Then user will be logged in

@myAccount
Scenario: User can open wishlist page
    Given user opens sign in page
	And enters cirrect credentials
	And user submits the login form
	When user opens my wishlist
	Then user can add new wishlist

	@myAccount
Scenario: User can create an account
    Given user opens sign in page
	And initiates a flow for creating an account
	And user enters all required personal details
	When submits the sign up form
	Then user will be logged in
	And user's full name is displayed

	@my Account
Scenario: User can search for a product and add it to the cart
    Given user enters a DRESS search term
    And user submits the search
    And opens first product from the list
    When user clicks on add to cart button
    And user proceeds to checkout
    Then cart page is opened
