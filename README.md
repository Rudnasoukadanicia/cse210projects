# cse210-ww-student-template
This is the starter code for students in the worldwide content version of CSE 210.

W07 : Expalain Programming with Classes 

I - Abstraction

Definition:
Abstraction is the process of simplifying complex ideas. Reducing the object plays a key role. As programmers, we constantly create and use abstractions. In practice, we create public classes and methods that represent actions, while hiding internal data structures and implementation details.

Example in a program:
In the YouTube Videos project, I created the `Video` class that contains the main information about a video, such as the title, author, and duration. Comments are managed via a separate `Comment` class. The user can interact with the videos and view the information without knowing how the comments are stored or processed.

Future Flexibility:
Thanks to abstraction, if I want to add additional features, such as likes or views, I can modify the `Video` or `Comment` class without changing the code that uses these classes. The public interface remains the same, making the program easy to extend.

II - Encapsulation

Definition:
Encapsulation is the act of enclosing something, such as in a capsule. This involves defining the behaviors we need for our classes and hiding the implementation details and preventing other parts of the program from accessing these details.

Example in a program:
In the Online Ordering project, the `Customer` class contains an `Address` object. The `_name` and `_address` attributes are private, and access is via `GetCustomerName()` and `GetAddress()`. The `Order` class can use these methods without directly accessing the internal variables.

Future Flexibility:
Encapsulation allows you to change the internal implementation of the `Address` or `Customer` class (such as adding a city or postal code) without impacting the rest of the program. Other classes still interact via public methods.

III - Inheritance

Definition:
Inheritance allows one class to obtain the attributes and methods of another class. The base class provides common behaviors, and derived classes can reuse or extend them.

Example in a program:
In the Mindfulness project, I created a base class `Activity` with attributes such as `Name`, `Description`, and `Duration`, as well as methods such as `StartMessage()` and `EndMessage()`. The derived classes `BreathingActivity`, `ReflectingActivity`, and `ListingActivity` inherit from `Activity` and add behaviors specific to each type of activity.

Future Flexibility:
Inheritance makes it easy to add new activities by creating new derived classes. The existing code for the base activities does not need to be modified, making the program modular and extensible.

IV - Polymorphism

Definition:
Polymorphism allows objects from different classes, but related by inheritance, to respond differently to the same method. A single interface can represent multiple implementation forms.

Example in a program:
In the Eternal Quest project, I created a base class `Goal` and derived classes `SimpleGoal`, `EternalGoal`, and `CheckListGoal`. All have the `RecordEvent()` method. When I call `RecordEvent()` on a `Goal` object, the correct version is executed based on the object's actual type, without needing to know its exact type.

Future Flexibility:
Polymorphism makes it easy to add new types of goals without changing the code that manages the goals. For example, I can create `NegativeGoal` where the points are lost, and `RecordEvent()` will work automatically thanks to polymorphism.

Overall Summary

These four principles—abstraction, encapsulation, inheritance, and polymorphism—make programs more modular, maintainable, and easy to extend. Each principle enables the separation of responsibilities, data protection, code reuse, and consistent handling of different objects, which is essential for developing flexible and scalable applications.