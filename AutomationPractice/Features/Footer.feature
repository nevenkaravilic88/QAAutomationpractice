Feature: Footer
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Footer
Scenario Outline: User can open links under Information section
	When user clicks on '<information link>' option
	Then '<page>' is displayed
Examples: 
    | information link | page |
    | Specials         | Price drop |
    | New products     | New products |
    | Best sellers     | Best sellers |
    | Our stores       | Our store |
    | Contact us                  | Contact |
	| Terms and conditions of use | Terms and conditions of use  |
	| About us                    | About us|
	| Sitemap                     | Sitemap|
	

@Footer
Scenario Outline: User can open links under My account 
    Given user opens sign in page
	And enters cirrect credentials
	And user submits the login form
	When user clicks on '<link>' option under Myaccount section
	Then correct '<page>'under Myaccount is displayed
Examples: 
    | link | page |
    | My orders        | Order history |
    | My credit slips  | Credit slips |
    | My addresses     | My addresses  |
    | My personal info | Your personal information|
    
	

	