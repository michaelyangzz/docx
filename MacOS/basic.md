# navigate to previous window
- command + tab

# look for processes that listen to port number
```sh
sudo lsof -nP -iTCP:5432 | grep LISTEN
```

# kill the process
```sh
sudo kill 1234
#force kill
sudo kill -9 1234
```

# remove passwords from Keychain Access 
```sh
# fetch the exact the item in the keychain
security find-internet-password -s dev.azure.com
```
```
the output:
keychain: "/Users/yourusername/Library/Keychains/login.keychain-db"
version: 512
class: "inet"
attributes:
    0x00000007 <blob>="dev.azure.com"
    0x00000008 <blob>=<NULL>
    "acct"<blob>="yourusername"
    "atyp"<blob>="dflt"
    "crtr"<uint32>=<NULL>
    "cusi"<sint32>=<NULL>
    "desc"<blob>="Internet password"
    "icmt"<blob>=<NULL>
    "invi"<sint32>=<NULL>
    "labl"<blob>=<NULL>
    "modt"<blob>=<NULL>
    "nega"<blob>=<NULL>
    "port"<uint32>=0
    "prot"<blob>=<NULL>
    "ptcl"<blob>="htps"
    "scrp"<sint32>=<NULL>
    "sdmn"<blob>=<NULL>
    "srvr"<blob>="dev.azure.com"
    "type"<uint32>=<NULL>
```

```sh
# delete the item
security delete-internet-password -s dev.azure.com -a yourusername -l "Internet password"
```