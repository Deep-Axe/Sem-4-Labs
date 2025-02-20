vi studentInformation.txt
: '
RegistrationNo:Name:Department:Branch:Section:Sub1:Sub2:Sub3
1234:XYZ:ICT:CCE:A:80:60:70
2345:ABC:ICT:IT:B:85:75:90
3456:DEF:IT:IT:A:88:92:76
4567:GHI:ICT:CCE:B:75:65:80
5678:JKL:MECH:ME:A:78:80:85
6789:MNO:IT:IT:B:90:88:85
7890:PQR:ICT:CCE:A:68:72:79
8901:STU:ECE:ECE:B:82:70:88
9012:VWX:CSE:CSE:A:95:98:92
1023:YZA:ICT:CCE:A:88:74:65
Example Input '

grep -c ':ICT:' studentInformation.txt
sed 's/:IT:/:Information Technology:/g' studentInformation.txt > ITStudents.txt
awk -F':' '$1=="1234" {print ($6+$7+$8)/3}' studentInformation.txt
sed -e '1s/.*/\U&/' studentInformation.txt
