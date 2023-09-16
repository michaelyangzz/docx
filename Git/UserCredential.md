# Please tell me who you are.
**Please Note: below setting just for commit codes, has nothing to do with git auth**
- git config --global user.email "michaelyangzz@msn.cn"
- git config --global user.name "Bei"

# Git Multiple accounts on Mac
## go to ssh folder to see all your keys
1. cd ~/.ssh

## generate three pairs of keys, -C to identify the key, -f name the key.
1. ssh-keygen -t rsa -C "xx.xx@xxx.com" -f "github-yangbei-tw"
1. ssh-keygen -t rsa -C "michaelyangzz@msn.cn" -f "github-michaelyangzz"
1. ssh-keygen -t rsa -C "xx.xx@xxx.com" -f "azure-devops-yangbei-tw"
## add keys to your SSH -agent
1. ssh-add --apple-use-keychain ~/.ssh/github-yangbei-tw
1. ssh-add --apple-use-keychain ~/.ssh/github-michaelyangzz
1. ssh-add --apple-use-keychain ~/.ssh/azure-devops-yangbei-tw