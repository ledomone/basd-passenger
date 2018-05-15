#!/bin/bash
projects=(Passenger.Tests Passenger.Tests.EndToEnd)
for project in ${projects[*]}
do
	echo Running tests for :$project
	dotnet xunit $project/$project.csproj
done
