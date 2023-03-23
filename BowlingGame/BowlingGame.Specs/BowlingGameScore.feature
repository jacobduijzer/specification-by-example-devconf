Feature: Bowling Game Score
	As a player
	I want to calculate my scores
	So I know if I am winning
	
Scenario: Throwing all balls in the gutter
	Given Janine is playing a game of bowling
	When she throws all balls in the gutter
	Then her total score should be 0
	
Scenario: Throwing one pin at every turn
	Given Janine is playing a game of bowling
	When she throws 1 pin at every turn
	Then her total score should be 20 

Scenario: Scoring a spare
	Given Janine is playing a game of bowling
	When she throws a spare
	And she throws 3 pins
	And she scores nothing else
	Then her total score should be 16 
	
Scenario: Scoring a strike
	Given Janine is playing a game of bowling
	When she throws a strike
	And she throws 3 pins
	And she throws 4 pins
	And she scores nothing else
	Then her total score should be 24 
	
Scenario: The perfect score
	Given Janine is playing a game of bowling
	When she throws 12 strikes
	Then her total score should be 300
	
Scenario: Just an ordinary game with a spare but no bonus
	Given Janine is playing a game of bowling
	When she scores 3 pins and 4 pins
	And she scores 1 pins and 0 pins
	And she throws a spare
	And she scores 0 pins and 9 pins
	And she scores nothing else
	Then her total score should be 27

	
	
	