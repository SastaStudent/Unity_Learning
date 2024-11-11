# 1. Physic Materials

### 1. Dynamic Friction (0–1): 
How much friction applied to the object when in motion. The higher the friction the more outside force (like gravity or an explosion) impacts it; 0 is ice, 1 is super-glue sticky.

### 2. Static Friction (0–1): 
How much force is needed to get the object moving in the first place basically; 0 means anything gets it going, 1 means it require a heavy amount of push

### 3. Bounciness (0–1): 
How bouncy the surface is when something collides with it (or it collides with something); 0 is your surface made of mud, 1 it is made of rubber.

### 4. Friction / Bounce Combine (Average, Minimum, Multiply, Maximum): 
This tells Unity which physics material takes priority when making the calculation. Defaults to “average” where it tries to work out a middle ground, but sometimes it is useful to use minimum (where the lowest value of the two objects colliding is used) or maximum (where the highest value is used), e.g. when a rubber ball hits a pile of mud, you don’t want to bouncing away, so use “Minimum”.

# Cheatsheet
## 1. Rubber Material
1. Dynamic: 0.8
2. Static: 0.9
3. Bounciness: 0.8
4. Friction Combine: Maximum
5. Bounce Combine: Average

## 2. Ice Material
1. Dynamic: 0.05
2. Static: 0.1
3. Bounciness: 0.05
4. Friction Combine: Multiply
5. Bounce Combine: Multiply

## 3. Wood Material
1. Dynamic: 0.475
2. Static: 0.475
3. Bounciness: 0
4. Friction Combine: Average
5. Bounce Combine: Average

## 4. Metal Material
1. Dynamic: 0.15
2. Static: 0.2
3. Bounciness: 0
4. Friction Combine: Minimum
5. Bounce Combine: Average

## 5. Mud Material
1. Dynamic: 1
2. Static: 0.9
3. Bounciness: 0
4. Friction Combine: Minimum
5. Bounce Combine: Minimum

# 2. Physics Joint
## 1. Fixed Joint

1. Fixed Joints restricts an object’s movement to be dependent upon another object.
2. This is somewhat similar to Parenting but is implemented through physics rather than Transform hierarchy.
3. The best scenarios for using them are when you have objects that you want to easily break apart from each other, or connect two object’s movement without parenting.

### Properties
<b>1. Connected Body :</b> Optional reference to the Rigidbody that the joint is dependent upon. If not set, the joint connects to the world.

<b>2. Break Force :</b> The force that needs to be applied for this joint to break.

<b>3. Break Torque :</b> The torque that needs to be applied for this joint to break.

<b>4. Enable Collision :</b> When checked, this enables collisions between bodies connected with a joint.

<b>5. Enable Preprocessing :</b> Disabling preprocessing helps to stabilize impossible-to-fulfil configurations.


## 2. Sprint Joint

1. The Spring Joint joins two Rigidbodies together but allows the distance between them to change as though they were connected by a spring.
2. The spring acts like a piece of elastic that tries to pull the two anchor points together to the same position.

### Property:
<b>1. Connected Body :</b>
The Rigidbody object that the object with the spring joint is connected to. If no object is assigned then the spring is connected to a fixed point in space.

You can use connected bodies to create chains of multiple Hinge Joints. Add a joint to each link in the chain, and attach the next link as the Connected Body.

<b>2. Connected Articulation :</b> Body	Optional reference to the ArticulationBody that the joint is dependent upon. If not set, the joint connects to the world.


<b>3. Anchor :</b>	The point in the object’s local space at which the joint is attached.

<b>4. Axis :</b>	The direction of the axis around which the body rotates. The direction is defined in local space.

<b>5. Auto Configure Connected Anchor :</b>	When enabled, Unity calculates the position of the connected anchor points automatically. Unity configures the anchor points to maintain the starting distance between them (that is, the distance you set in the scene view while positioning the objects).

<b>6. Connected Anchor : </b>The point in the connected object’s local space at which the joint is attached.

Spring	Determines the force per unit of distance that the joint uses. The Spring Joint acts like a piece of elastic that tries to pull the two anchor points together to the same position. The strength of the pull is proportional to the current distance between the points.
Damper	Amount that the spring is reduced when active. To prevent the spring from oscillating endlessly, set a Damper value that reduces the spring force in proportion to the relative speed between the two objects. The higher the value, the more quickly the oscillation decreases.

<b>7. Min Distance :</b>	Set a minimum distance range over which the spring does not apply any force. If the distance between the objects exceeds this distance, the Spring Joint applies force to bring the objects back together.

<b>8. Max Distance :</b>	Set a maximum distance range over which the spring does not apply any force. If the distance between the objects exceeds this distance, the Spring Joint applies force to bring the objects back together.

<b>9. Tolerance : </b>Changes error tolerance. Allows the spring to have a different rest length.

<b>10. Break Force : </b>The force that needs to be applied for this joint to break.

<b>11. Break Torque : </b>The torque that needs to be applied for this joint to break.

<b>12. Enable Collision : </b>
Enable this setting if the two connected objects should register collisions with each other.

<b>13. Enable Preprocessing :</b>	Disabling preprocessing helps to stabilize impossible-to-fulfil configurations.

<b>14. Mass Scale : </b>	The scale to apply to the inverted mass and inertia tensor of the Rigidbody, ranging from 0.00001 to infinity. This is useful when the joint connects two Rigidbodies of largely varying mass. The physics solver produces better results when the connected Rigidbodies have a similar mass. When your connected Rigidbodies vary in mass, use this property with the Connect Mass Scale property to apply fake masses to make them roughly equal to each other. This produces a high-quality and stable simulation, but reduces the physical behaviour of the Rigidbodies.

<b>15. Connected Mass Scale : </b>The scale to apply to the inverted mass and inertia tensor of the connected Rigidbody, ranging from 0.00001 to infinity.

## 3. Hinge Joint

1. The Hinge Joint groups together two Rigidbodies, constraining them to move like they are connected by a hinge.
2. It is perfect for doors, but can also be used to model chains, pendulums, and other objects that have a similar hinge-like motion.
3. A single Hinge Joint should be applied to a GameObject
4. The hinge rotates at the point specified by the Anchor property, moving around the specified Axis property.
5. The Hinge Joint has Spring, Motor, and Limits properties, which allow you to fine-tune the joint’s behaviors.

## 4. 8. Detecting Collisions with OnCollisionEnter

1. OnCollisionEnter is a built-in method used to detect collisions between two GameObjects that have Collider components and are involved
 in a physics simulation. This method is part of the MonoBehaviour class, which means it can be implemented in your scripts to react when a collision occurs.
2. The OnCollisionEnter method is triggered when the collider attached to the GameObject with the script comes into contact with another collider, 
and both GameObjects must have Rigidbody components (the one receiving the collision typically needs a Rigidbody with "isKinematic" set to false for 
the collision to be detected).

```csharp
void OnCollisionEnter(Collision collision)
{
    // Code to handle the collision
}
```
3. <b>collision:</b> The Collision object provides information about the collision, such as the other object involved, the contact points, and the relative velocity.
### Key Elements of the Collision Object
The Collision parameter contains several important pieces of information:

1. collision.gameObject: The GameObject that collided with the object that this script is attached to.
2. collision.contacts: An array of ContactPoint objects that contain information about the points where the collision happened.
3. collision.relativeVelocity: The relative velocity between the two colliding objects at the moment of impact.
4. collision.rigidbody: The Rigidbody component of the object that collided, if it has one.

```csharp
using UnityEngine;
public class CollisionDetector : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Print the name of the object that collided with this object
        Debug.Log("Collided with: " + collision.gameObject.name);

        // Check if the object is tagged as "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player collided with this object!");
        }
    }
}
```
# 5. Raycasting

1. Raycasting is a technique used to cast an invisible ray (a straight line) from a point in a specified direction and detect whether it hits any objects along its path. Raycasting is commonly used for things like detecting objects under a mouse click, shooting mechanics, line-of-sight checks, and environmental interactions.

## Basic Concepts
1. Ray: A ray is a vector originating from a point in space and extending infinitely in a given direction.
2. Hit: If a ray intersects a collider in the scene, the ray "hits" the collider, and you can gather information about the collision (such as the point of impact, the normal of the surface, and which object was hit).
 
3. Unity provides a few methods for raycasting, but the most common one is Physics.Raycast. This function casts a ray from a point in a specific direction and returns information about what the ray hits.

```csharp
RaycastHit hit;
if (Physics.Raycast(origin, direction, out hit, maxDistance))
{
    // Ray hit something, the hit variable contains information
    Debug.Log("Hit: " + hit.collider.gameObject.name);
}
```

## Parameters of Physics.Raycast:
1. origin: The starting point of the ray (a Vector3).
2. direction: The direction in which the ray is cast (a normalized Vector3).
3. hit: An instance of the RaycastHit struct that will contain information about what the ray hit (this is passed by reference using out).
4. maxDistance (optional): The maximum distance the ray should travel. If this is omitted, the ray travels infinitely.
5. layerMask (optional): A layer mask to specify which layers should be considered for collision detection.
6. queryTriggerInteraction (optional): Determines whether or not to hit trigger colliders. (Default is QueryTriggerInteraction.UseGlobal.)

#### This code used in Test_02 Raycasting 3D shooting
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RayCastTry : MonoBehaviour
{
    public GameObject bullet;
    public float disappearTime = 2f;
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (Physics.Raycast(transform.position, Vector3.forward, out RaycastHit hitInfo, 25f))
            {
                GameObject bull = Instantiate(bullet, hitInfo.point, Quaternion.identity);
                Destroy(bull, disappearTime);
                // Debug.Log("Hitted");
                // Debug.Log(hitInfo.collider.name);
                Debug.DrawRay(transform.position, hitInfo.point);
            }
            else
            {
                try
                {
                   GameObject bull = Instantiate(bullet, transform.position, Quaternion.identity);
                    Destroy(bull, disappearTime); 
                }
                catch (System.Exception ex)
                {
                    Debug.Log("Message"+ ex.Message);
                    throw ex;
                }                
            }     
        }
    }
}
```