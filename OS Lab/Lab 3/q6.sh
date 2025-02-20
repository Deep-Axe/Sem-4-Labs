#!/bin/bash

for file in *; do

  [ -f "$file" ] || continue

  sed -i -E 's/^ex:/Example:/g; s/\. *ex:/\. Example:/g' "$file"
done

echo "Replacement completed in all files."
