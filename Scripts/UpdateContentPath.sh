#!/bin/bash

# Byt till skriptets plats
cd "$(dirname "$0")" || exit
cd ..
dotnet run --project Mania.Util -- Mania.Core -v

