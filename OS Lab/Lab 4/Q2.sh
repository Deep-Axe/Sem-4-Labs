#!/bin/bash

if [ $# -eq 0 ]; then
    echo "Usage: $0 <file1> <file2> ..."
    exit 1
fi

for file in "$@"; do
    if [ -f "$file" ]; then  
        
        read -p "Do you want to delete '$file'? (y/n): " choice
        case "$choice" in
            [Yy]* ) rm "$file"; echo "'$file' deleted.";;
            [Nn]* ) echo "'$file' not deleted.";;
            * ) echo "Invalid input. Skipping '$file'.";;
        esac
    else
        echo "'$file' does not exist."
    fi
done
