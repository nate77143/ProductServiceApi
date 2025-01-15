
-Configure database connection string<br>
-Auto Migration applied<br>

v1 endpoint - Accessible without authentication https://localhost:5001/api/v1/Products?pageNumber=1&pageSize=3 <br>
v2 endpoint - Requires authentication to access https://localhost:5001/api/v2/Products?pageNumber=1&pageSize=3 <br>

Implemented IdentityServer sample authentication used to secure v2 endpoint.<br>
requires to run both project IdentityServer and ProductServiceWebAPI at the same time.<br>

 Get Token Url:&nbsp;&nbsp;&nbsp;&nbsp; https://localhost:5005/connect/token<br>
 grant_type:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;client_credentials<br>
 scope:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; productApi<br>
 client_id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;productClient<br>
 client_secret:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; secret<br>

