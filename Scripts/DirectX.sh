#!/bin/bash

# Byt till skriptets plats
cd "$(dirname "$0")" || exit

dotnet run --project Source/Mania.DirectX/ -p:DefineConstants="DIRECTX"