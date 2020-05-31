#!/bin/bash
set -ev

dotnet build -c $BUILD_CONFIG ./IdentityService/IdentityService.sln

if [ $? -eq 0 ]
then
        if [ "$BUILD_CONFIG" = "debug" ]; 
        then
                dotnet test ./IdentityService/IdentityService.UnitTests/IdentityService.UnitTests.csproj -v normal --no-build
        else
                echo Skip testing on non-debug build
        fi
fi

if [ $? -eq 0 ]
then
        if [ "${TRAVIS_PULL_REQUEST}" = "false" ] && [ "${TRAVIS_BRANCH}" = "master" ]; 
        then
                dotnet nuget push ./NugetProject/bin/$BUILD_CONFIG/NugetProject.*.nupkg --api-key $NUGET_API_KEY --source $NUGET_SOURCE --skip-duplicate
        else
                echo Skip nuget for non-master build
        fi
fi