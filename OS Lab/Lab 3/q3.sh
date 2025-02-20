#!/bin/bash



echo "Replacing .txt with .text"
result=`find . -depth -name *.txt`
for i in $result 
do
	echo renaming $i 
    mv $i ${i%.txt}.text
done
echo "All files renamed!"