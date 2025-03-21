# BibleReadingSystem

This is a simple Bible Reading System

## Setup

This project requires Docker to be installed on your machine. To set up the local SQL server, run the following command:

```bash
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=yourStrong_Password" -p 1433:1433 -d mcr.microsoft.com/mssql/server:latest
```

## TODO
- [ ] Users need to be able to create instances of new reading plans
- [ ] Users need to be able to complete instances of reading plans