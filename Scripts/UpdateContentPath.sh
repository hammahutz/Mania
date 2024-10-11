#!/bin/bash

# Byt till skriptets plats
cd "$(dirname "$0")" || exit
cd ..

dotnet run --project Source/Mania.Util -- Source/Mania.Core -v -s Content/Dist
