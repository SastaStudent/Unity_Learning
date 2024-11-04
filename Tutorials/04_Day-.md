# Enabling and Disabling Components
### Key Points
1. Disabling a Component: Disabling a component stops its functionality (e.g., a disabled Collider will not detect collisions).
2. Disabling a GameObject: When you disable a GameObject, all components attached to it are also disabled.
### Performance:
 It's often more efficient to enable/disable components or GameObjects rather than destroying and recreating them.
### Practical Use Cases
UI Elements: Enable/disable UI components based on game state (e.g., showing/hiding menus).
Character Abilities: Toggle abilities or behaviors during gameplay (e.g., enabling a shield).
Object Pooling: Manage active/inactive states of objects in a pool for performance.


# Activating GameObjects

#### SetActive
#### Purpose:
 Activates or deactivates the entire GameObject and all its components.
#### Effect:
When you call SetActive(false), the GameObject becomes inactive. It will not be rendered, will not receive input, and its scripts will not execute.
When you call SetActive(true), the GameObject is reactivated along with all its components.
#### Hierarchy:
 If a parent GameObject is set to inactive, all child GameObjects are also deactivated, regardless of their individual states.

# Alert always check gameObject or component is null or not, if null don't perform operation on it.

# Translate and Rotate

#### Translate
1. Changing the position of GameObject in game world.
2. This can be done either by directly setting the position using the Transform component or by applying movement vectors over time.


#### Rotation
1. Rotation means Rotating the Game Object in any direction (up,down,left,right)

#### LookAt
In Unity, the LookAt method is used to make one GameObject face another 
GameObject or a specific point in 3D space. This is commonly used for 
character and camera movement to create more immersive interactions. 

###### Example
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;//this is reference of other object
    void Update()
    {
        transform.LookAt(target);  
    }
}
```

#### Destroy

In Unity, the Destroy method is used to remove GameObjects, components, 
or assets from the scene. Once an object is destroyed,
 it can no longer be referenced or interact with other objects.

###### Syntax
```csharp
Destroy(gameObject); // Destroys the GameObject this script is attached to
Destroy(otherGameObject); // Destroys a specified GameObject
//For this we have to pass reference of other gameObject
Destroy(GetComponent<Renderer>()); // Destroys the Renderer component
// using this we can destroy game Components
Destroy(gameObject, 2.0f); // Destroys the GameObject after 2 seconds
// Using this we can delete a gameobject at some delay
```
###### Example
```csharp
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    void Update()
    {
        // Destroy the GameObject when the "D" key is pressed
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Destroying GameObject");
            Destroy(gameObject);
        }
    }
}
```

# Interpolations

###### Linear Interpolation
```txt
Linear Interpolation (Lerp) is a mathematical technique used to
find a value that lies between two given values based on a linear
progression. In the context of Unity, Lerp allows us to smoothly 
transition between two points, colors, rotations, or any other 
properties over time, resulting in visually pleasing animations 
and transitions.
```