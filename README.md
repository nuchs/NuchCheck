# NuchCheck

NuchCheck is a library which provides a set of methods that allow you to make statements about objects. The methods will check if these statements are true and if not will raise an exception describing why this is the case.

The intention is that you can use these methods to validate input at trust boundries within your code.

It has three aims

To be 

* Ergonomic - it should be easy to use and should add a minimum of boiler plate
* Descriptive - when a statement is found to be false a useful error message should be produced
* Extendable - It should be easy to use the existing statements as primatives to build new ones

## Example use

Each of the statements are implemented as extension methods on the types they check e.g. to make sure an item is not null you would use

```csharp
void Foo(Bar bar)
{
    bar.ItIsNotNull();
}
```

If 'bar' were to be null then an exception would be raised saying 

"Null check: object should not be null but is"

All of the checks optionally take a name parameter which is used to customise the error message so the error message for the following code 

```csharp
void Foo(Bar bar)
{
    bar.ItIsNotNull(nameof(bar));
}
```

Would be 

"Null check: bar should not be null but is"

## Statements

The following statements are suppported

### Object

* IsNotNull - States that the target is not null
* IsNull - States that the target is null

### Bool

* IsTrue - States that the target is true
* IsFalse - States that the target is false

### IEquatable

* IsEqualTo(other) - States that the target is equal to other (and that target is not null)
* IsNotEqualTo(other) - States that the target is not equal to other (and that target is not null)

### IComparable

* IsLessThan(other) - States that the target is less than other (and that neither target nor other is null)
* IsLessThanOrEqualTo(other) - States that the target is less or equal than other (and that neither target nor other is null)
* IsGreaterThan(other) - States that the target is greater than other (and that neither target nor other is null)
* IsGreaterThanOrEqualTo(other) - States that the target is greater or equal than other (and that neither target nor other is null)
* LiesBetween(lower, upper, type) - States that the target lies in the range between lower and upper (and that the target, lower and upper are all not null). The optional type parameter indicates if the range is open or not. It can have one of the following four values

```csharp
public enum Range
{
    Inclusive,
    UpperBoundInclusive,
    LowerBoundInclusive,
    Exclusive
}
```

### IEnumerable

* IsNotEmpty - States that target sequence is not empty or null (calls the count method)

### String

* IsNotEmpty - States that the string is not empty or null
* IsNotWhiteSpace - States that the string is not whitespace, empty or null

## Adding new Statements

To create a new statement you just need to create a static class with an extension method for each statement you wish to add. The last argument of the method should be an optional string into which users can enter the name of the object the statement is being made about. If a statement is not true then a ValidationException should be thrown. The target of the statement should be returned to allow chaining.

```csharp
public Video
{
    public byte[] data { get; private set; }
    public Format format { get; private set } 
    
    // etc.
}

public static class VideoChecker
{
    public static IsOfSupportedFormat(this Video target, string name="video")
    {
    
    }
}
```
