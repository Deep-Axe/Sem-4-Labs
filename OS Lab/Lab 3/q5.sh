#!/bin/bash
# Script to copy files with specified extension to a new folder
# echo "Params to be passed during execution: $0 <extension> <destination_folder>"

if [ -z "$1" ] || [ -z "$2" ]; then
  echo "The usage dictates: $0 <extension> <destination_folder>"
  exit 1
fi

ext="$1"
dest="$2"

# Create the destination folder if it doesn't exist
mkdir -p "$dest"

# Copy files with the specified extension to the destination folder
find . -maxdepth 1 -type f -name "*.$ext" -exec cp {} "$dest" \;