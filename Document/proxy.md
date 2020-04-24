### git proxy
* git config --global --add https.proxy http://<username>:<password>@<proxy-server-url>:<port>
* git config --global --add http.proxy http://<username>:<password>@<proxy-server-url>:<port>
### npm proxy
* npm config set proxy http://<username>:<password>@<proxy-server-url>:<port>
* npm config set https-proxy http://<username>:<password>@<proxy-server-url>:<port>

> when the password or username contains speciafic char like @, #, use encodeURIComponent("@") to get <b>%40</b> instead
~, !, @, #, $, %, ^, &, *, ? 
