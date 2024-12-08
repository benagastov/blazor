#!/bin/bash

# Download .NET SDK installer
curl -sSL https://dot.net/v1/dotnet-install.sh > dotnet-install.sh
chmod +x dotnet-install.sh

# Install .NET SDK
./dotnet-install.sh --channel 8.0 --install-dir $HOME/.dotnet

# Add dotnet to PATH
export PATH=$HOME/.dotnet:$PATH
export DOTNET_ROOT=$HOME/.dotnet

# List current directory for debugging
pwd
ls -la

# Build the Blazor project
dotnet publish "./BlazorOnGitHubPages/BlazorOnGitHubPages.csproj" -c Release -o output

# Copy the published output to the Cloudflare Pages public directory
cp -r output/wwwroot/* .
