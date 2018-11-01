# AutoMapper

Automapper configuration for independent modules.<br/>
Automapper version 7

## Information

For a well defined layered application, higher layer should not depend on lower layer entities but should depend on respective layered dtos. The definative layer should depend on entities.data models pertaining to its need.

## Application details

The code is structured to have 2 domain models

- Accounts
- Users

The User model defines employee entity and Account model defines account details.<br/>
Both the models define lower layer entities. Respective higher layer entities is defined by Account and User Dtos.<br/>
The Account model requires User model to be registered as part of its registration.

## How it's done

We define the base mapping configuration in the individual MapperConfiguration files and initialize using the MapperInitializer.<br/>
The Main Registration for all the domain entities are defined in the RegisterMapppping file.
