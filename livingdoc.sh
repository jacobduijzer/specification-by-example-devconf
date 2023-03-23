#!/bin/bash

dotnet tool update --global SpecFlow.Plus.LivingDoc.CLI

dotnet build BowlingGame/BowlingGame.sln
dotnet test BowlingGame/BowlingGame.sln

~/.dotnet/tools/livingdoc \
  feature-folder BowlingGame/BowlingGame.Specs \
  -t BowlingGame/BowlingGame.Specs/bin/Debug/net7.0/TestExecution.json \
  --binding-assemblies BowlingGame/BowlingGame.Specs/bin/Debug/net7.0/BowlingGame.Specs.dll \
  --output livingdoc.html

/usr/bin/firefox livingdoc.html
