# Vectors

Vector is a quantity which have magnitude and directions (maths)
Vector is a representation of 2d and 3d space.

# 2d Vectors in Unity

1. 2D vector represent by Vector2 which stores x and y cordinates

2. Syntax
```C#
Vector2 position = new Vector2(x, y);
```
# Methods
Represents the vector (0, 0).
1. Vector2.one: Represents the vector (1, 1).
2. Vector2.up: Represents the vector pointing up (0, 1).
3. Vector2.down: Represents the vector pointing down (0, -1).
4. Vector2.left: Represents the vector pointing left (-1, 0).
5. Vector2.right: Represents the vector pointing right (1, 0).
# Common Methods
1. Vector2.Distance(a, b): Calculates the distance between two Vector2 points.
2. Vector2.Lerp(a, b, t): Linearly interpolates between two vectors a and b by a factor t (from 0 to 1).
3. normalized: Returns a unit vector (same direction but with a magnitude of 1).
4. magnitude: Returns the length (magnitude) of the vector.
5. sqrMagnitude: Returns the squared length (avoiding a square root operation for efficiency).

# Creating a Vector
```csharp
Vector2 Vect = new Vector2(2,3);
// Access Vector
int x = Vect.x;
int y=Vect.y;
```
# Vector Operations
```csharp
// Addition
Vector2 A = new Vector2(2,4);
Vector2 B= new Vector2(8,10);

Vector2 Result = A+B; //result (10,14)

// Subtraction
Vector2 Sub = B-A; //result (6,6)

// dot product

int DotResult = Vector2.Dot(A,B); //

// Scaled up
Vector2 Scaled = 2 * A; // (4,8)

// Scale down
Vector2 Down = A/2; //(1,2)

// Magnitude
int mag = A.magnitude; // pythagorous
int SqaurMag = A.sqrMagnitude;

// normalized
int ans = A.normalized;

// Distance
int dist = Vector2.Distance(A,B);

```
