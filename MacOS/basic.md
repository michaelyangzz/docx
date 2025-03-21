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