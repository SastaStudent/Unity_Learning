# 1. Colliders
1. Purpose: Colliders define the physical boundaries of an object in Unity. They’re used to detect and respond to collisions with other objects.
### Types of Colliders: 
Unity provides various colliders, such as
1. Box Collider
2. Sphere Collider
3. Capsule Collider
4. Mesh Collider
5. which can be used to create different shapes around an object.

### Functionality: 
When attached to a GameObject, a collider will register collision events with other colliders and can trigger responses (such as bouncing off walls).
### Usage:
Typically used to define the solid area of physical objects (like walls, players, or ground) so that other objects can detect and interact with them.
# 2. Colliders as Triggers
### Purpose:
When a collider is set as a trigger, it doesn’t physically block objects but instead detects when objects enter, exit, or stay within its boundaries.
### Trigger Property: 
To make a collider act as a trigger, enable the Is Trigger checkbox on the collider component.
```csharp
using UnityEngine;
public class TriggerTry : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Other object is Entered");
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("Other object inside the Trigger obj");
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Other object is Exit");
    }
}
```
### Usage: 
Often used for areas where you want an action to occur without physical collision. For example, triggers can be used to detect when a player enters a zone (like a checkpoint), picks up an item, or interacts with interactive elements.
### Functionality: 
In code, trigger events like OnTriggerEnter, OnTriggerStay, and OnTriggerExit can be used to define what happens when an object enters, stays in, or exits the trigger area.
# 3. Rigidbodies
### Purpose: 
Rigidbody is a component that adds physics-based properties to an object, allowing it to be affected by forces such as gravity, velocity, and collisions.
### Physics Interaction: 
By adding a Rigidbody to an object, Unity’s physics engine can control its movement and respond to collisions with other objects that also have colliders.
### Key Properties:
1. Mass: The mass of the object (in kilograms by default).
2. Gravity: Controls whether the object is affected by gravity.
3. Drag: How much air resistance affects the object when moving from forces. 0 means no air resistance, and infinity makes the object stop moving immediately.
4. Angular Drag: How much air resistance affects the object when rotating from torque. 0 means no air resistance. Note that you cannot make the object stop rotating just by setting its Angular Drag to infinity.
5. Use Gravity: If enabled, the object is affected by gravity.
6. Is Kinematic	If enabled, the object will not be driven by the physics engine, and can only be manipulated by its Transform. This is useful for moving platforms or if you want to animate a Rigidbody that has a HingeJoint attached.

### Interpolate	
Try one of the options only if you are seeing jerkiness in your Rigidbody’s movement.
1. None: No Interpolation is applied.
2. Interpolate: Transform is smoothed based on the Transform of the previous frame.
3. Extrapolate:	Transform is smoothed based on the estimated Transform of the next frame.

### Collision Detection	
Used to prevent fast moving objects from passing through other objects without detecting collisions.
1. Discrete: Use Discreet collision detection against all other colliders in the scene. Other colliders will use Discreet collision detection when testing for collision against it. Used for normal collisions (This is the default value).
2. Continuous: Use Discrete collision detection against dynamic colliders (with a rigidbody) and continuous collision detection against static MeshColliders (without a rigidbody). Rigidbodies set to Continuous Dynamic will use continuous collision detection when testing for collision against this rigidbody. Other rigidbodies will use Discreet Collision detection. Used for objects which the Continuous Dynamic detection needs to collide with. (This has a big impact on physics performance, leave it set to Discrete, if you don’t have issues with collisions of fast objects)
3. Continuous Dynamic: Use continuous collision detection against objects set to Continuous and Continuous Dynamic Collision. It will also use continuous collision detection against static MeshColliders (without a rigidbody). For all other colliders it uses discreet collision detection. Used for fast moving objects.

### Constraints	
Restrictions on the Rigidbody’s motion:-
1. Freeze Position	Stops the Rigidbody moving in the world X, Y and Z axes selectively.
2. Freeze Rotation	Stops the Rigidbody rotating around the local X, Y and Z axes selectively.