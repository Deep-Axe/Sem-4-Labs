#!/bin/bash

bubble_sort() {
    local arr=("$@")  
    local n=${#arr[@]}  
    local temp
    for ((i = 0; i < n-1; i++)); do
        for ((j = 0; j < n-i-1; j++)); do
            if [[ "${arr[j]}" > "${arr[j+1]}" ]]; then
                
                temp="${arr[j]}"
                arr[j]="${arr[j+1]}"
                arr[j+1]="$temp"
            fi
        done
    done
    echo "${arr[@]}"  

if [ $# -lt 1 ]; then
    echo "Usage: $0 \"string1\" \"string2\" \"string3\" ..."
    exit 1
fi
sorted_strings=$(bubble_sort "$@")
echo "Sorted Strings: $sorted_strings"
