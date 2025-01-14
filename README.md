
-Configure database connection string
-Auto Migration applied

v1 enpoint - Accessible without authentication
v2 enpoint - Requires authentication to access

Implemented IdentityServer sample authentication used to secure endpoint for this project.
This will requires to run both project IdentityServer and ProductServiceWebAPI at the same time.

 Get Token Url:   https://localhost:5005/connect/token
 grant_type:      client_credentials
 scope:           productApi
 client_id:       productClient
 client_secret:   secret
