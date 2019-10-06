# promo-code

## Commands
`dotnet restore`

`dotnet build`

`dotnet run`

## Create the postgres data base

```sql
CREATE DATABASE promo
    WITH 
    OWNER = postgres
    ENCODING = 'UTF8'
    CONNECTION LIMIT = -1;
```

## Endpoints

Return all promo codes.
GET `api/promoCodes` 


Return actives promo codes.
GET `api/promoCodes/actives`

Return a promo code
GET `api/promoCodes/5`

Generation of new promo codes for events.
POST `api/promoCodes`

Change a promo code
PUT `api/promoCodes/5`

Deactivate a promo code.
DELETE `api/promoCodes/5`

Validity a promo code.
GET `api/promoCodes/5/validity`