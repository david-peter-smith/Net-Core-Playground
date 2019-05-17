# Net-Core-Playground

## Class Naming Convention

[Entity][Verb][Role/Classification]

For example...

Given:
[Entity] User
[Verb] Create
[Role/Classification] Service

Then:
UserCreateService

Rational
The Entity-Verb-Role (EVR) convention best utilizes the nature of how people think (in objects) and intellisense lookups. Although sentences in natural language tend to be closer to the form of Verb-Entity-Role, the enumeration of objects more closely resembles how we look for things. Our interaction with the world pre-dates language constructs and therefore more closely resembles our internal symbolic model of the world. We also usually employ multiple verbs per object which means there are fewer objects then verbs and roles. 
