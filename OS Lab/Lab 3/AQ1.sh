#!/bin/bash

if [ -z "$1" ]; then
  echo "Usage: $0 <number>"
  exit 1
fi

num=$1

if [ "$num" -lt 2 ]; then
  echo "$num is not a prime number."
  exit 0
fi

for ((i=2; i*i<=num; i++)); do
  if [ $((num % i)) -eq 0 ]; then
    echo "$num is not a prime number."
    exit 0
  fi
done

echo "$num is a prime number."
