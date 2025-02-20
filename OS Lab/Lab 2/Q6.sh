for i in {1..10}; do wc /dev/null & done
pkill wc
