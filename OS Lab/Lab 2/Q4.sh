#!/bin/bash

grep -l "MIT" * | while read file; do
    echo "Processing file: $file"
    sed -n 's/MIT/Manipal Institute of Technology/gp' "$file"
done
