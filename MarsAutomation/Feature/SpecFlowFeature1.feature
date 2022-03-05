Feature: Seller_Add Profile Details
As a seller in Mars QA
   I want the feature to add my Profile details
   So people seeking skills can look my details
	

   Scenario: A profile picture displays clear picture of seller in my Profile
	Given the Mars QA website and credentials to login
	When I login in the website
	Then Profile picture is displayed on my Profile page
	Then close the browser instance

   Scenario: A description can be added by seller in my Profile
	Then  I click on pencil icon
	Then find the text box to enter new value 
	Then click Save button

   Scenario: Languages can be added by seller in my Profile
	Then I click on Add New button
	Then find dropdown button to select language level
	Then click Add button
	Then close the browser instance