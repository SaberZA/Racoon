Racoon
======
[![Gitter](https://badges.gitter.im/Join Chat.svg)](https://gitter.im/SaberZA/Racoon?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

In-Memory Redis Database for Unit Testing

Background
----------

I primarily develop on the Microsoft stack and with the advocation of Test-Driven Development, I need an effective tool to build test-driven systems without having to think about back-end data persistence.

My plan is to build an in-memory database that allows me to abstract away the database layer until I have decided which back-end technology I will carry forward to the production environment.

I have chosen Redis because of its lack for a data-schema and high performance. Having a schema-less environment grants me freedom to craft my logic layer without building a Microsoft Sql Server centric design.
