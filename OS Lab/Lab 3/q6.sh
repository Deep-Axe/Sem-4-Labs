#!/bin/bash

for file in *; do
  [ -f "$file" ] || continue
  sed -i -E 's/^ex:/Example:/g; s/\.Example:/\.Example:/g' "$file"
done