# Please tell me who you are.
**Please Note: below setting just for commit codes, has nothing to do with git auth**
- git config --global user.email "michaelyangzz@msn.cn"
- git config --global user.name "Bei"

# How to use multiple accounts on Mac for git
## go to ssh folder to see all your keys
1. cd ~/.ssh

## generate three pairs of keys, -C to identify the key, -f name the key.
1. ssh-keygen -t rsa -C "xx.xx@xxx.com" -f "github-yangbei"
1. ssh-keygen -t rsa -C "michaelyangzz@msn.cn" -f "github-michaelyangzz"
1. ssh-keygen -t rsa -C "xx.xx@xxx.com" -f "azure-devops-yangbei"
## add keys to your SSH agent
1. ssh-add --apple-use-keychain ~/.ssh/github-yangbei
1. ssh-add --apple-use-keychain ~/.ssh/github-michaelyangzz
1. ssh-add --apple-use-keychain ~/.ssh/azure-devops-yangbei
## view all keys in your SSH agent
1. ssh-add -l
## imports all keys.pub on corresponding github accounts
### copy the xx.pub to clipboard. then paste onto git server.
1. pbcopy < ~/.ssh/github-yangbei.pub
1. pbcopy < ~/.ssh/github-michaelyangzz.pub
1. pbcopy < ~/.ssh/azure-devops-yangbei.pub
### you have to authorize the key for your organization on github.

## open ssh config to add host entries for github
- open -e ~/.ssh/config
- examples:
    ```
    #michaelyangzz
    Host github.com-michaelyangzz
    HostName github.com
    User git
    IdentityFile ~/.ssh/github-michaelyangzz

    #azure devops yangbei
    Host ssh.dev.azure.com-yangbei
    HostName azure.com
    User git
    IdentityFile ~/.ssh/azure-devops-yangbei
    ```
- HostName point to knownhost file
## update the remote to match above host
- git remote set-url origin git@github.com-{your-username}:{the-repo-organisation-or-owner-user-name}/{the-repo-name}.git

## Final Step
1. git config user.email "xxxx@xx.com"
1. git config user.name "xxx"
1. without this step, git will use the default user.name to commit codes.  
1. **this step has nothing to do with git auth**

## How to use multiple accounts on Windows for git
only one difference is the ssh-agent, you can use below command to start ssh agent in windows manually.
1. start the ssh-agent in the background
```
Get-Service -Name ssh-agent | Set-Service -StartupType Manual
Start-Service ssh-agent
```

## trouble shoot
1. after restart your laptop. git push probably failed for no valid ssh keys in your ssh agents(default keys is not correct), please ssh-add -l to view all active keys to see if they are correct. 