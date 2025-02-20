#!/bin/bash

if [ $# -ne 2 ]; then
    echo "Usage: $0 <-linecount | -wordcount | -charcount> <filename>"
    exit 1
fi

option="$1"
file="$2"

if [ ! -f "$file" ]; then
    echo "Error: File '$file' not found."
    exit 1
fi

case "$option" in
    -linecount)
        echo "Line Count: $(wc -l < "$file")"
        ;;
    -wordcount)
        echo "Word Count: $(wc -w < "$file")"
        ;;
    -charcount)
        echo "Character Count: $(wc -m < "$file")"
        ;;
    *)
        echo "Invalid option. Use -linecount, -wordcount, or -charcount."
        exit 1
        ;;
esac
