#!/bin/bash
rm -rf lab3_tester
mkdir lab3_tester
cd ./lab3_tester
touch atotheb.txt tothectothedtothe.txt e.txt
cd ..


echo "Replacing .txt with .text"
result=`find . -depth -name *.txt`
for i in $result 
do
	echo renaming $i 
    mv $i ${i%.txt}.text
done
echo "All files renamed!"