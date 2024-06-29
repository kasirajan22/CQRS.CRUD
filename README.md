
# CQRS using MediatR

Here's a rewritten version of the text in simpler terms:

CQRS is a way to separate how we read and write data in an application. It divides data operations into two types:

* Queries: These are read-only operations that retrieve data without changing it.
* Commands: These are operations that make changes to the data, such as creating, updating, or deleting it.

This separation helps make large applications more manageable, easier to test, and scalable. It also allows us to optimize read and write operations separately, which can improve performance. However, for simple applications with basic data access needs, CQRS might add unnecessary complexity.

