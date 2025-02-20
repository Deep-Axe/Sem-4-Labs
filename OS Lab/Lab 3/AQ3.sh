#!/bin/bash

if [ -z "$1" ]; then
  echo "Usage: $0 <filename>"
  exit 1
fi

file="$1"

awk 'NR % 2 == 0' "$file" > evenfile
awk 'NR % 2 == 1' "$file" > oddfile

echo "Even lines saved in evenfile."
echo "Odd lines saved in oddfile."
