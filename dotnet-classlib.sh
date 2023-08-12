#!/bin/bash

mkdir src

dotnet new classlib -o "src/Xo.Core.$1"

dotnet new sln -o "src" --name "Xo.Core.$1"

dotnet sln src add src/Xo.Core.$1
