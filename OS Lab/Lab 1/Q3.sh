
ls *.txt  

ls | grep '[0-9]'

ls | awk 'length($0) >= 4'

ls | grep -E '^[^aeiouAEIOU]'
