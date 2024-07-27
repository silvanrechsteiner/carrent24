# carrent24

Es soll ein neues Autovermietungssystem „CarRent“ erstellt werden. Das System soll aus einem Server-Teil (WebApi) und optional einen Web-Client bestehen.

## Inhalt des Projekts

* Vision
* Domain Model & Use Cases
* Project Layout
* Design Shared-Kernel Komponenten
  * Entity
  * ValueObject
  * Events
  * Result / Error
* Die Daten sollen mittels CQRS Pattern in eine SQL Datenbank gelesen und gespeichert werden können.
  * Design Command Handler
  * Design Request Handler
  * Design QueryExecutor
  * Design Repository Pattern
* Die Business Logik soll auf dem Backend laufen und eine REST APIs anbieten.
* Api Design (OpenApi, StatusCodes)
