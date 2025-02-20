#!/bin/bash

if [ $# -ne 1 ]; then
    echo "Usage: $0 <filename>"
    exit 1
fi

file="$1"

if [ ! -f "$file" ]; then
    echo "Error: File '$file' not found!"
    exit 1
fi

filename="${file%.*}"     
extension="${file##*.}"     

if [ "$filename" == "$extension" ]; then
    duplicate="${file}_copy"  
else
    duplicate="${filename}_copy.${extension}"  
fi

cp "$file" "$duplicate"

echo "Duplicate copy created: $duplicate"
