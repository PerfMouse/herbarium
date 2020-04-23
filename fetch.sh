#!/bin/bash
git fetch

echo ""
echo "Would you want to pull all these files?"
read -p "[Y]es/[N]o: " verify_pull
echo ""

if [[ $verify_pull = "y" ]]
then
    git pull
    echo "Updated all the files to the master branch"
fi
if [[ $verify_pull = "n" ]]
then
    echo "Canceled operation"
fi
