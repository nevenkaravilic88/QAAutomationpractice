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
    | Specials         |      |
    | New products     |      |
    | Best sellers     |      |
    | Our stores       |      |

	| Contact us                  |  |
	| Terms and conditions of use |  |
	| About us                    |  |
	| Sitemap                     |  |
	