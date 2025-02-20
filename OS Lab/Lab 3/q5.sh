#!/bin/bash

read -p "Enter the file extension (e.g., .text, .txt, etc.): " extension
read -p "Enter the destination folder name: " destination

if [ ! -d "$destination" ]; then
    mkdir "$destination"
fi

find . -maxdepth 1 -type f -name "*$extension" -exec cp {} "$destination" \;

echo "All files with '$extension' have been copied to '$destination' folder."
