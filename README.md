
# CQRS using MediatR

### CQRS (Command Query Responsibility Segregation)

CQRS is a way to separate how we read and write data in an application. It divides data operations into two types:

* Queries: These are read-only operations that retrieve data without changing it.
* Commands: These are operations that make changes to the data, such as creating, updating, or deleting it.

This separation helps make large applications more manageable, easier to test, and scalable. It also allows us to optimize read and write operations separately, which can improve performance. However, for simple applications with basic data access needs, CQRS might add unnecessary complexity.

### Mediator Pattern

The Mediator pattern helps manage how objects interact with each other. Instead of objects talking directly to each other, they communicate through a mediator. This way, the objects don't need to know about each other, which makes them less dependent on each other.

For example, a service sends its request to the mediator, and the mediator then passes it on to the appropriate request handler for processing.

The Mediator pattern is useful for implementing CQRS. Commands and queries are sent to the mediator, which then maps them to their respective handlers. This separation helps make the system more modular and easier to manage.
