## What is dependency injection?
Throughout the lifetime of an application, there are classes we will need in multiple places. These classes can be thought of as services. 

The problem that D.I seeks to solve is that when we need these classes, we need to create instances of these classes.

 D.I provides us with a mechanism to instantiate these classes as needed into various parts of our application. We can stick our classes into a globally available D.I container and pull them in as needed.

## Singletons
Creates an instance of the service the first time it is required. Afterwards, it passes the exact same instance to all other consumers of that service.

## Transient
Creates a unique instance each time that it is required.

## Scoped
Creates an instance for each request

```c#
// return the created at response
// include the route we can find this newly created hotel inside nameof
// include the id into the route (must be named the same as the id in the GetHotelById route)
return CreatedAtAction(nameof(GetHotelById), new { id = hotel.HotelId }, hotel);
```