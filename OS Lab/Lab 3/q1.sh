#!/bin/bash

# Write a shell script to find whether a given file is the directory or regular file.
echo "Enter file/dir name: "
read file
if [ -f $file ]
then
echo $file "---> It is an ORDINARY FILE."
elif [ -d $file ]
then
echo $file "---> It is a DIRCTORY."
else
echo $file "---> It is alien!"
fi
