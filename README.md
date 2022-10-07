# zigzagtest
 
Client -> Angular App
* Login/Register
* Select from a list with different assets/currencies
* See a summary about the asset/currency chosen.

Server -> .NET 6
* RestAPI
    * Authentication APIs (Login/Register)
        * EF Core
        * Microsoft Identity
        
* GraphQL/Hot Chocolate
    * Integration with 3rd party service (https://cryptingup.com/apidoc/)
        * Get list of assets
        * Get a specific asset
