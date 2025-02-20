#!/bin/bash

if [ -z "$1" ]; then
  echo "Usage: $0 <number>"
  exit 1
fi

num=$1
fact=1

for ((i=1; i<=num; i++)); do
  fact=$((fact * i))
done

echo "Factorial of $num is $fact"
