#!/bin/bash

if [ $# -ne 2 ]; then
    echo "Usage: $0 <start_year> <end_year>"
    exit 1
fi

start_year=$1
end_year=$2

if ! [[ "$start_year" =~ ^[0-9]{4}$ && "$end_year" =~ ^[0-9]{4}$ ]]; then
    echo "Error: Enter valid years in YYYY format."
    exit 1
fi

if [ "$start_year" -gt "$end_year" ]; then
    echo "Error: Start year should be less than or equal to end year."
    exit 1
fi

echo "Files created between $start_year and $end_year:"
find . -maxdepth 1 -type f -newermt "$start_year-01-01" ! -newermt "$(($end_year + 1))-01-01" -ls
