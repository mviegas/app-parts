# Multiple single-purpose APIs for a event-driven modular monolith

The goal of this repository is to study the pros and cons of having multiple APIs for a event-driven modular monolithic application. The final result for this study will be a descripted Architecture Decision Log of when this approach could be used and what would be the wins and losses with it. 

This case study relies on having two APIs:
* BFF - Backend for Frontend
* Integrations API

Each one of these APIs will interact with a monolith with vertical-sliced features, meaning that each feature might have its own controller.

> Disclaimer: this is still WIP. 

## Trade-off evaluation

### Pros/Wins

This approach allows:

* Each module of the monolith can be developed independently of the other;
* A module feature can be developed combining a vertical-slice and hexagonal architecture for loose coupling and isolation;
* Within the modules, each feature can have its own integration tests using controllers as entrypoints to cross the entire stack;
* Within the APIs, each endpoint can have its own e2e test to verify cross-cutting concerns (i.e. Security).

### Cons/Challenges

* Some concerns that usually lie together must be defined separetely, that might introduce some lack of cohesion to the development. Still to think about it.
	* Within the API - cross-cutting concerns:
		* Middlewares;
		* Security.
	* Within modules - endpoint-specific concerns:
		* Endpoints;
		* Return objects and status codes;

* A single feature, if shared between two APIs will, need to have two controllers/endpoints or share the same controller, which means no isolation.
