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

# 4. Adding Physics Forces
1. To add a force to a GameObject, you need to have a Rigidbody component on it.
2. You can use the AddForce method from the Rigidbody to apply a force in a specific direction.
```csharp
using UnityEngine;

public class AddForceExample : MonoBehaviour
{
    public float forceAmount = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Apply force in the forward direction
            rb.AddForce(transform.forward * forceAmount, ForceMode.Impulse);
        }
    }
}
```
```csharp
AddForce(Vector3 force, ForceMode mode) takes in a direction (Vector3) and the force mode.
```
### Force Modes:
1. ForceMode.Force: Continuous force (affected by mass).
2. ForceMode.Impulse: Instant force, useful for sudden movements (like jumps).
3. ForceMode.Acceleration: Continuous but ignores mass.
4. ForceMode.VelocityChange: Instant, ignores mass, and changes velocity directly.

### Physics Force on axis
1. We can also apply force on the axis such as (x,y,z).
like.
2. Here player.AddForce(float x, float y, float z): for applying forces toward axis.
```csharp
using System;
using Unity.VisualScripting;
using UnityEngine;
public class ForceTry : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody player;
    void Start()
    {
        player = GetComponent<Rigidbody>();
        if(player == null) {
            Debug.Log("Rigidbody is NULL");
        }        
    }

    void Update()
    {
        bool btn = Input.GetButtonDown("Jump");
        if(btn ){
            player.AddForce(0f,force,0f);                      
        }        
    }
}
```
# 5. Adding Physics Torque
1. Torque is the rotational equivalent of force. It can be applied using AddTorque.

```csharp
using UnityEngine;
public class AddTorqueExample : MonoBehaviour
{
    public float torqueAmount = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            // Apply torque to rotate the object around the up axis
            rb.AddTorque(transform.up * torqueAmount, ForceMode.Impulse);
        }
    }
}
```
```csharp
AddTorque(Vector3 torque, ForceMode mode) applies a rotational force in the specified direction.
```
1. Adjust the Force Mode and torqueAmount to control the intensity and behavior of the rotation.