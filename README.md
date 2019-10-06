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
`dotnet restore`

`dotnet build`

`dotnet ef database update`

`dotnet run`

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
