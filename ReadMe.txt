--http://www.csharpstar.com/design-pattern-interview-questions/

01) What is Design Pattern? A design pattern is a general reusable solution to a commonly occurring problem within a given context in software design. A design pattern is not a finished design that can be transformed directly into source or machine code. 
    It is a description or template for how to solve a problem that can be used in many different situations. Patterns are formalized best practices that the programmer can use to solve common problems when designing an application or system.
02) What all are the advantages of Design Patterns?
    Structural problems like: Abstraction, Encapsulation, Data Hiding, Separation of Concerns, Separation of Interface and Implementation, Single point of reference, Coupling and Cohesion etc..
    Non Functional problems like: Efficiency, Reliability, Interoperability, Testability, Reusability etc..
03) What all are the types of Design Patterns? There are 3 types of Design Pattern:
    Creational Patterns: This type of pattern address problems of creating an object and separating it from operations. Singleton, Factory, Abstract Factory, Prototype, Builder
    Structural Patterns: This type of pattern address problems of using object oriented constructs to organize classes and objects. Adapter, Bridge, Composite, Decorator, Facade, Flyweight, Proxy
    Behavioral Patterns: This type of pattern address problems of assignment of responsibilities between objects, or, encapsulating behavior in an object and delegating requests to it. Command, Mediator, Observer, Strategy, Template
04) Why singleton over static? The big difference between a singleton and a bunch of static methods is that singletons can implement interfaces (or derive from useful base classes, although that's less common, in my experience), 
    so you can pass around the singleton as if it were "just another" implementation. A singleton allows access to a single created instance - that instance (or rather, a reference to that instance) can be passed as a parameter to 
    other methods, and treated as a normal object. A static class allows only static methods.
05) What is Singleton Design Pattern? Singleton ensures a class only has one instance. Singleton Provides a global point of access to it. For multithreaded safety use volatile on the static singleton instance to ensure that assignment 
    to the instance variable completes before the instance variable can be accessed. Use a static syncRoot object instance to lock on, rather than locking on the type itself, to avoid deadlocks.
    Use double-check locking approach solves the thread concurrency problems while avoiding an exclusive lock in every call to the Instance property method. It also allows you to delay instantiation until the object is first accessed. 
06) What is Factory Design Pattern? Define an Interface for creating an object but let subclasses decide which class to instantiate. Lets a class defer instantiation to subclasses 
07) What is Abstract Factory Design Pattern? Provides an interface for creating families of related or dependent objects without specifying their concrete classes. Abstract Factory patterns acts a super-factory which creates other factories. 
    This pattern is also called as Factory of factories. Think abstract factory to create database connection objects, connection, command, etc
08) What is Adapter Design Pattern? The adapter pattern is adapting between classes and objects. This pattern involves a single class called adapter which is responsible for communication between two independent or incompatible interfaces.
    This works like a bridge between two incompatible interfaces. Think various payment gateway components, Paypal, credit card, bitcoin. 
09) What is Composite Design Pattern? Composite pattern composes objects in term of a tree structure to represent part as well as whole hierarchies. Composite pattern creates a class contains group of its own objects. This class provides ways to modify its group of same objects.
    Composite pattern is used when we need to treat a group of objects and a single object in the same way
10) What is Decorator Design Pattern? Decorator pattern is used to add new functionality to an existing object without changing its structure. Decorators provide a flexible alternative to subclass for extending functionality.
	This pattern creates a decorator class which wraps the original class and add new behaviors/operations to an object at run-time. Think all the File.IO stream classes
11) What is Facade Design Pattern? Facade Design Pattern makes a software library easier to use, understand and test. Facade Design Pattern make the library more readable. Facade Design Pattern reduce dependencies of outside code on the inner workings of a library
	Facade Design Pattern wrap a poorly designed collection of APIs with a single well-designed API.
12) What is Strategy Design Pattern? Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from the clients that use it. Capture the abstraction in an interface, bury implementation details in derived classes.
	Think strategies for validation, strategies for password policies, strategies for processing service call responses
13) What is Template Pattern? Define the skeleton of an algorithm in an operation, deferring some steps to client subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
    Base class declares algorithm 'placeholders', and derived classes implement the placeholders.
14) What is Observer Pattern? Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. Encapsulate the core (or common or engine) components in a Subject abstraction, 
	and the variable (or optional or user interface) components in an Observer hierarchy. The "View" part of Model-View-Controller. Think stock (publisher), when price changes notify all investors (subscribers)
15) What is Mediator Pattern? Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently.
	Design an intermediary to decouple many peers. Promote the many-to-many relationships between interacting peers to "full object status". The Mediator Pattern allows objects to communicate with each other through a common instance of a mediator class. 
	It promotes loose coupling and prevents objects from referring to each other directly. Through a common instance of a mediator the classes subscribing to it can communicate by sending messages to this instance and it will notify the other subscribed instances.
	Used a lot in WPF for MVVM. Think WPF app has many controls that all work with "Job" entity. Controls will subscribe to mediator's eventhandler JobChanged. When a job changes it will invoke the mediator's OnJobChanged method which will publish JobChanged
	to the subscribers (controls) to update it's own UI, see EventsDelegatesLambdas CommunicatingBetweenControls project. Think commandtower (mediator) and aircrafts. Aircrafts communicate with each other through commandtower.
16) What is Command Pattern? Encapsulate a request as an object, thereby letting you parametrize clients with different requests, queue or log requests, and support undoable operations. 
	Promote "invocation of a method on an object" to full object status. An object-oriented callback. Think calculator commands where you can execute and unexecute