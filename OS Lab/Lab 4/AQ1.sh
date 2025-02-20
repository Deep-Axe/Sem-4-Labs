#!/bin/bash

if [ $# -ne 1 ]; then
    echo "Usage: $0 <filename>"
    exit 1
fi

file="$1"


if [ ! -e "$file" ]; then
    echo "Error: File '$file' does not exist."
    exit 1
fi


permissions=$(stat -c "%A" "$file")

owner_perm=${permissions:1:3}
group_perm=${permissions:4:3}
others_perm=${permissions:7:3}

echo "Permissions for file: $file"
echo "Owner  : $owner_perm"
echo "Group  : $group_perm"
echo "Others : $others_perm"
