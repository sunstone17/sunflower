## Add
### git proxy
* git config --global https.proxy http://<username>:<password>@<proxy-server-url>:<port>
* git config --global http.proxy http://<username>:<password>@<proxy-server-url>:<port>
### npm proxy
* npm config set proxy http://<username>:<password>@<proxy-server-url>:<port>
* npm config set https-proxy http://<username>:<password>@<proxy-server-url>:<port>

> when the password or username contains speciafic char like @, #, use encodeURIComponent("@") to get <b>%40</b> instead
~, !, @, #, $, %, ^, &, *, ? 


## Remove
* git config --global --unset http.proxy
* git config --global --unset https.proxy
* npm config delete proxy

## Get
* git config --global --get http.proxy
* git config --global --get https.proxy
