# CSharpFundamentals
## Following the pluralsight course by  the master Scott Allen


I haver learnt things again, like:

A class is a type.
An object is a representation of that type

### Encapsulation:
I can say it is a mechanism to reduce complexity of the code. Hiding the details of an specific operation and just calling that in one function, class and so on.

Reference Types vs Value Types:
  To know if a type is a value or reference type is easy. 
  Go to the definition of a type with f12, 
  for example int type
  All types that are a class  are referece types 
  All types that a a struct are value types
  The string type is referece type but behaves as a value type

  ### ref vs out keyword
    If you want to pass something by reference you must to use the ref keyword.
    If you want to pass something by reference you must to use the out if you want that assign a value to that its mandatory keyword.
    
 ### Events with delegates
 
  With a delegate we describe what a method would look like. In other words. What is the return type and parameter type and numbers of parameters.
  What a delegate allows me to do is define a variable that can point to, and invoque different methods.
  Those method must have the same shape and structure 
  
  Example:
  A delegated to log messages
  Goal of a delegate:
  I need some sort of indirection, abstraction , encapsulation between my code and the code that does the logging.
  So when I call a method and pass my messsage to log, I dont want a method hardcoded that just log to the console or to a file.
  I want the ability to have a variable or field that can point to different methods that have the same structure but perhaps different implementations.
  
  Sintaxis:
  public delegate string WriteLogDelegate(string logMessage);
  
  Event:
  Announce that something happens in some way
  Handle an event:
  That's what we say when we add a method to this particular event that we want invoked when this class raises that event.
  So raising the event is really just invoking the delegate, and handling the event is just using that += operator to add a method into  the invovation list
  
  
  Pilars of POO
  
  Encapsulation
      Allow us to hide details about our code with access modififers and properties
      It's the key to good software design
  Inheritance
  Polymorphism
  
  ### Abstrac class
  We use it to define common members for types
  Can implement or not methods.
  
  ### Interface
  Is only going to describe the memebers that should be available on a specific type
  Does not implement methods
  
