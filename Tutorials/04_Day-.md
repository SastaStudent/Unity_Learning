# Enabling and Disabling Components
### Key Points
1. Disabling a Component: Disabling a component stops its functionality (e.g., a disabled Collider will not detect collisions).
2. Disabling a GameObject: When you disable a GameObject, all components attached to it are also disabled.

```csharp
using UnityEngine;

public class EnabeDisableComponents : MonoBehaviour
{
    // Start is called before the first frame update
    private BoxCollider myBox;
    private MeshRenderer myMesh;
    public MonoBehaviour myScript;
    void Start()
    {
        myBox = GetComponent<BoxCollider>();
        myMesh = GetComponent<MeshRenderer>();
    }
    // Enabling Disabling Script
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V)){
            myBox.enabled = !myBox.enabled;
        }
        if(Input.GetKeyDown(KeyCode.B)){
            gameObject.SetActive(false);//Deactivating GameObject
        }
        if(Input.GetKeyDown(KeyCode.N)){
            myMesh.enabled= !myMesh.enabled;
        }
        if(Input.GetKeyDown(KeyCode.M)){
            myScript.enabled= !myScript.enabled;
        }   
    }
}
```

### Performance:
1. It's often more efficient to enable/disable components or GameObjects rather than destroying and recreating them.
### Practical Use Cases
1. UI Elements: Enable/disable UI components based on game state (e.g., showing/hiding menus).
2. Character Abilities: Toggle abilities or behaviors during gameplay (e.g., enabling a shield).
3. Object Pooling: Manage active/inactive states of objects in a pool for performance.


# Activating GameObjects

#### SetActive
```csharp
using UnityEngine;

public class ActiveScript : MonoBehaviour
{
    [SerializeField] //Attribute to display private member in Inspector window
    private GameObject obj;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G)){
            if(obj!=null){
                obj.SetActive(true);//it set the gameobject Active and deactivate code is above on enableing/disabling
            }
            else{
                Debug.Log("Object is NULL");
            }
        }       
    }
}
```
#### Purpose:
1. Activates or deactivates the entire GameObject and all its components.
#### Effect:
1. When you call SetActive(false), the GameObject becomes inactive. It will not be rendered, will not receive input, and its scripts will not execute.
2. When you call SetActive(true), the GameObject is reactivated along with all its components.
#### Hierarchy:
1. If a parent GameObject is set to inactive, all child GameObjects are also deactivated, regardless of their individual states.

#### Alert always check gameObject or component is null or not, if null don't perform operation on it.

# Translate and Rotate

#### Translate
1. Changing the position of GameObject in game world.
2. This can be done either by directly setting the position using the Transform component or by applying movement vectors over time.

```csharp
using UnityEngine;
public class Translate : MonoBehaviour
{
    public float speed = 10f;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.Translate(x*Vector3.right*speed*Time.deltaTime);
        transform.Translate(y*Vector3.forward*speed*Time.deltaTime);        
    }
}
```
#### Rotation
1. Rotation means Rotating the Game Object in any direction (up,down,left,right)

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 10f;
    void Start()
    {
         transform.rotation= Quaternion.Euler(0,0,0);
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            // transform.Rotate(new Vector3(0,90,0));
            transform.rotation = Quaternion.Euler(0, 90,0);
        } 
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 270,0);
        } 
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.Euler(0, 180,0);
        } 
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0,0);
        }     
    }
}
```

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
1. Linear Interpolation (Lerp) is a mathematical technique used to find a value that lies between two given values based on a linear
progression.
2. In the context of Unity, Lerp allows us to smoothly 
transition between two points, colors, rotations, or any other 
properties over time, resulting in visually pleasing animations 
and transitions.
```