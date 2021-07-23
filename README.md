# *Animal Shelter API*

#### *Animal Shelter API, 07/23/2021*

#### By **Chris Ramer**

## Description

An API that returns info pertaining to the animals within an animal shelter and allows for modifying that info.

## Setup/Installation Requirements

Clone this repo and follow the instructions for [using the client to interact with this API](https://github.com/ChrisRamer/building-an-api-ind-project-client)

Using that client, you can go to each of the endpoints listed below.

## Endpoints

Each endpoint begins with the required `v{apiVersion}` with the version being an `int` or a `float`.
* `v{apiVersion}/animals` - **(GET)** Returns list of all animals in the shelter
* `v{apiVersion}/animals` - **(POST)** Allows you to add a new animal with JSON properties for: `animalId (int)`, `name (string)`, `species (string)`, `gender (string)` and `age (int)`
* `v{apiVersion}/animals/{id}` - **(GET)** Returns details of the animal with the given `id`
* `v{apiVersion}/animals/{id}` - **(PUT)** Allows you to edit the details of the animal with the given `id` using JSON properties for: `animalId (int)`, `name (string)`, `species (string)`, `gender (string)` and `age (int)`
* `v{apiVersion}/animals/{id}` - **(DELETE)** Allows you to delete the animal with the given `id`

## Versions

* `1.0` - Only has GET for `/animals` endpoint
* `2.0` - Has GET for `/animals` and GET for `/animals/{id}` endpoints
* `3.0` - Has GET and POST for `/animals` and GET for `/animals/{id}` endpoints
* `4.0` - Has GET and POST for `/animals` and GET and PUT for `/animals/{id}` endpoints
* `5.0` - Has GET and POST for `/animals` and GET, PUT, and DELETE for `/animals/{id}` endpoints
* `6.0` - Easter egg :)

## Technologies Used

* C#
* ASP.NET
* .NET Core

### License

Copyright (c) 2021 **Chris Ramer**

This software is licensed under the MIT license.