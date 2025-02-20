#!/bin/bash

#menu driven program to search for patterns in a file and display,delete all occurrences of the patterns
if [ $# -lt 2 ]; then
    echo "Usage: $0 <pattern1> <pattern2> ... <filename>"
    exit 1
fi

file="${@: -1}"

if [ ! -f "$file" ]; then
    echo "Error: File '$file' not found!"
    exit 1
fi

patterns=("${@:1:$#-1}")

while true; do
    
    echo -e "\nChoose an operation:"
    echo "1. Search for patterns in the file"
    echo "2. Delete all occurrences of the patterns"
    echo "3. Exit"
    
    read -p "Enter your choice (1-3): " choice
    
    case "$choice" in
        1)
            echo -e "\nSearching for patterns in '$file':"
            for pattern in "${patterns[@]}"; do
                echo "Pattern: '$pattern'"
                grep --color=auto "$pattern" "$file"
            done
            ;;
        
        2)
            echo -e "\nDeleting occurrences of patterns..."
            for pattern in "${patterns[@]}"; do
                sed -i "s/$pattern//g" "$file"
            done
            echo "All occurrences deleted!"
            ;;

        3)
            echo "Exiting script."
            exit 0
            ;;
        
        *)
            echo "Invalid choice! Please enter a valid option."
            ;;
    esac
done
