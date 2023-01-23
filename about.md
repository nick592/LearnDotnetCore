## API (presentation layer)
Contains our controllers, validate the incoming requests (this is different from model validation). Also routes DTOs to the necessary services

## Services
Business logic. It manipulates our entities and business rules to achieve specific outcomes.

## Domain
Contains the business entities of our application. The real life idea of bookings and associated entities will be encapsulated in this layer. The business rules, constraints and validation associated with these entities will also be stored here.

## DataAccess
Interacts directly with the database. Should be isolated enough such that we should switch to another type of database interaction system without affecting the other layers of the app.