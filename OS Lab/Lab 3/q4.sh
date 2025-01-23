#!/bin/bash

echo "Enter basic salary:"
read basic_sal
echo "Enter Teaching Allowance:"
read ta


percent=$(echo "0.1 * $basic_sal" | bc)

gross_salary=$(echo "$basic_sal + $ta + $percent" | bc)

echo "Gross Salary is: $gross_salary"