# promo-code

## Create the postgres data base

```sql
CREATE DATABASE promo
    WITH 
    OWNER = postgres
    ENCODING = 'UTF8'
    CONNECTION LIMIT = -1;
```

## Commands
`dotnet restore` This will restore the project dependencies.

`dotnet build` This will compile the code.

`dotnet ef database update` This will run the migrations creating the tables and columns at the database.

`dotnet run` This will run the project.

## Endpoints
 GET `api/promoCodes` 
- Return all promo codes.

 GET `api/promoCodes/actives`
- Return actives promo codes.

 GET `api/promoCodes/5`
- Return a promo code

 POST `api/promoCodes`
- Generation of new promo codes for events.

 PUT `api/promoCodes/5`
- Change a promo code

 DELETE `api/promoCodes/5`
- Deactivate a promo code.

 GET `api/promoCodes/5/validity`
- Validity a promo code.


## Examples

- Creating a promo code

POST `https://localhost:5001/api/promocodes`
```json
{
    "Description": "testing promocode",
    "ExpireDate": "2019-10-10",
    "Amount": 1000,
    "IsActive": true,
    "RadiusInKilometers": 3.5
}
```