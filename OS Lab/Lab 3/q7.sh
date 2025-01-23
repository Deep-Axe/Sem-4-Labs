#!/bin/bash

# delete even numbered lines in a file
echo "Enter the file:"
read file

echo "Before Deletion"
cat $file
sed -i '0~2d' $file

echo -e '\n\n\nPost Deletion'
cat $file