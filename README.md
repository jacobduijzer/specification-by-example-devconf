# Specification By Example - DevConf 2023

In deze repository kun je de presentatie en de voorbeeldcode vinden van mijn talk voor [DevConf 2023](https://devconf.nl/).

## The Bowling Game

Het voorbeeldproject is een implementatie van de [Bowling Game Kata](https://kata-log.rocks/bowling-game-kata). Het project is voorzien van unit tests en specificaties. Het script om de 'living doc' te genereren is een bash script, mocht je onder windows de documentatie willen genereren, voer dan de volgende stappen uit:

```bash
dotnet tool update --global SpecFlow.Plus.LivingDoc.CLI

dotnet build BowlingGame/BowlingGame.sln
dotnet test BowlingGame/BowlingGame.sln

%USERPROFILE%\.dotnet\tools\livingdoc feature-folder BowlingGame\BowlingGame.Specs  -t BowlingGame\BowlingGame.Specs\bin\Debug\net7.0\TestExecution.json --binding-assemblies BowlingGame\BowlingGame.Specs\bin\Debug\net7.0\BowlingGame.Specs.dll --output livingdoc.html

```
