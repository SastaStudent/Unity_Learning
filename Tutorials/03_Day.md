# 1. Access Modifier -> AccessBility

1. public	-> Anywhere.

2. private	-> Only within the containing class.

3. protected -> Within the containing class and derived classes.

4. internal	-> Only within the same assembly.

5. protected internal -> Within the same assembly or in derived classes.

6. private protected -> Within the containing class and derived classes in the same assembly.

# 2. Awake and Start

### (i). Awake
1. The first method to be called on a MonoBehaviour is Awake. It is called as soon as the MonoBehaviour is loaded into the scene. 
2. This means that if the GameObject with the script already exists in the scene when it starts then Awake will be called immediately.
3. Otherwise, if the GameObject with the script is instantiated or the script is added after the start of the scene, Awake will be called then.
### Uses for Awake
1. Awake is only ever called once and so it is often best used for setting up any references between scripts that will exist for as long as the scene does.

### (ii). OnEnabled
1. Its executed after the Awake() method
2. OnEnabled execute multiple times when script is enabled.

```csharp
using UnityEngine;

public class AwakeAndOnEnabled : MonoBehaviour
{    void Awake()
    {
        Debug.Log("Awake Executed");
    }
    void OnEnable()
    {
        Debug.Log("On Enable Executed");
    }
}
```

### (iii). Start
1. Start method called after Awake method
2. It executes only once and it will execute when script is enabled.
3. It is used for initialization of gameObjects

```csharp
using UnityEngine;

public class AwakeAndOnEnabled : MonoBehaviour
{    void Awake()
    {
        Debug.Log("Awake Executed");
    }
    void Start()
    {
        Debug.Log("Start Executed");
    }
}
```

# 3. Update and FixedUpdate

```csharp
using UnityEngine;
using System.Collections;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    void FixedUpdate ()
    {
        // Called every physic step
        // Fixed update interval are consistent
        // Used for regular update such as
        // Adjusting physics (Rigidbody) objects.
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }
    
    
    void Update ()
    {
        // Called every frame
        // Used for regular updates such as
        // moving non-physics object
        // Simple Timer
        // Taking inputs
        Debug.Log("Update time :" + Time.deltaTime);
    }
}
```