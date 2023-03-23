Feature: Multiple Bowling Games
As a player
I want to calculate my scores
So I know if I am winning

    Background:
        Given Janine is playing a game of bowling

    Scenario: A poor game
        When she scores the following
          | Round | Roll 1 | Roll 2 |
          | 1     | 1      | 1      |
          | 2     | 1      | 1      |
          | 3     | 1      | 1      |
          | 4     | 1      | 1      |
          | 5     | 1      | 1      |
          | 6     | 1      | 1      |
          | 7     | 1      | 1      |
          | 8     | 1      | 1      |
          | 9     | 1      | 1      |
          | 10    | 1      | 1      |
        Then her total score should be 20

    Scenario: A game with a strike
        When she scores the following
          | Round | Roll 1 | Roll 2 |
          | 1     | 10     | x      |
          | 2     | 1      | 1      |
          | 3     | 1      | 1      |
          | 4     | 1      | 1      |
          | 5     | 1      | 1      |
          | 6     | 1      | 1      |
          | 7     | 1      | 1      |
          | 8     | 1      | 1      |
          | 9     | 1      | 1      |
          | 10    | 1      | 1      |
        Then her total score should be 30

    Scenario: A game with a spare
        When she scores the following
          | Round | Roll 1 | Roll 2 |
          | 1     | 0      | 10     |
          | 2     | 1      | 1      |
          | 3     | 1      | 1      |
          | 4     | 1      | 1      |
          | 5     | 1      | 1      |
          | 6     | 1      | 1      |
          | 7     | 1      | 1      |
          | 8     | 1      | 1      |
          | 9     | 1      | 1      |
          | 10    | 1      | 1      |
        Then her total score should be 29

    Scenario: The perfect game
        When she scores the following
          | Round | Roll 1 | Roll 2 |
          | 1     | 10     | x      |
          | 2     | 10     | x      |
          | 3     | 10     | x      |
          | 4     | 10     | x      |
          | 5     | 10     | x      |
          | 6     | 10     | x      |
          | 7     | 10     | x      |
          | 8     | 10     | x      |
          | 9     | 10     | x      |
          | 10    | 10     | x      |
          | 11    | 10     | x      |
          | 12    | 10     | x      |
        Then her total score should be 300