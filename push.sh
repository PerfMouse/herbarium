 #!/bin/bash
 git add *
 
 echo ""
 echo "Adding all the files..."
 echo ""
 
 git status
 
 echo ""
 echo "Are these all the files you want to update?"
 read -p "[Y]es/[N]o: " verify_push
 
 if [[ $verify_push = "y" ]]
 then
    read -p "Update message: " update_msg
    echo ""
    
    git commit -m $update_msg
    git push
    
    echo ""
    echo "Succesfully pushed all files to master branch"
 fi
 if [[ $verify_push = "n" ]]
 then
    echo ""
    echo "Canceled!"
 fi
