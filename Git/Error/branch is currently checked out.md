Ref: https://stackoverflow.com/questions/2816369/git-push-error-remote-rejected-master-master-branch-is-currently-checked

You can simply convert your remote repository to bare repository (there is no working copy in the bare repository - the folder contains only the actual repository data).

Execute the following command in your remote repository folder:

**git config --bool core.bare true**

Then delete all the files except .git in that folder. And then you will be able to perform git push to the remote repository without any errors.

