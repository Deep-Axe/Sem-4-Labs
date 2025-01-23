echo "Doing apropos for file names in specific dir";
read string;

echo "Enter the file path (rel path will do to):";
read path;

echo "Matched files: ";
ls $path/*$string*; 