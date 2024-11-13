# 1. How To children of a Game Object

## Method 1. Easy
```csharp
List<Transform> children = GetChildren(obj.transform);
    private List<Transform> GetChildren(Transform obj)
    {
        List<Transform> children = new List<Transform>();
        foreach (Transform child in obj)
        {
            children.Add(child);
        }

        return children;
    }
```
### We Can also Find Childs of Child

```csharp
    GameObject BoardObject = GameObject.FindWithTag("Board");
    List<Transform> MainChilren = GetChildren(BoardObject.transform);
    foreach(var mainChild in MainChilren)
        {
            // Debug.Log(mainChild.name);
            List<Transform> row = GetChildren(mainChild);
            foreach(Transform child in row)
            {
                // Debug.Log(child.name);
                foreach(Transform OpChild in child)
                {
                    OpChild.gameObject.SetActive(false);
                }
                
            }
        }
```

### Some Useful Methods to GetChildren
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* Danndx 2022 (youtube.com/danndx)
From video: youtu.be/KhvokgokrQE
thanks - delete me! :) */


public class SCR_GetChildren : MonoBehaviour
{
    void Start()
    {
        // Getting Data --------------------------------------------------------

        // - Get Children
        List<Transform> children = GetChildren(transform, false);

        // - Get Children Recursively
        //List<Transform> children = GetChildren(transform, true);

        // - Get Children Hierarchy
        //Dictionary<Transform, dynamic> children = GetChildrenHierarchy(transform);

        // - Children Extension Methods
        //List<Transform> children = gameObject.GetChildren(false);
        //Dictionary<Transform, dynamic> children = gameObject.GetChildrenHierarchy();

        // - Unity Array (warning: also includes parent)
        //Transform[] children = gameObject.GetComponentsInChildren<Transform>();

        // Accessing Data ------------------------------------------------------

        // - List/Array
        // foreach(Transform child in children)
        // {
        //     Debug.Log(child.name);
        // }

        // - Dictionary
        //ReadChildrenHierarchy(children);
    }

    List<Transform> GetChildren(Transform parent, bool recursive)
    {
        /** Get a list of children from a given parent, either the direct
            descendants or all recursively. **/

        List<Transform> children = new List<Transform>();

        foreach(Transform child in parent)
        {
            children.Add(child);
            if(recursive)
            {
                children.AddRange(GetChildren(child, true));
            }
        }

        return children;
    }

    Dictionary<Transform, dynamic> GetChildrenHierarchy(Transform parent)
    {
        /** Get a dictionary hierarchy of all children under a given parent. **/

        Dictionary<Transform, dynamic> children = new Dictionary<Transform, dynamic>();

        foreach(Transform child in parent)
        {
            children.Add(child, GetChildrenHierarchy(child));
        }

        return children;
    }

    void ReadChildrenHierarchy(Dictionary<Transform, object> hierarchy)
    {
        /** Read a dictionary hierarchy of children. **/
        
        foreach(KeyValuePair<Transform, object> child in hierarchy)
        {
            Debug.Log(child.Key); // Do something here...

            if(child.Value != null)
            {
                ReadChildrenHierarchy((Dictionary<Transform, object>)child.Value);
            }
        }
    }
}
```

### we can achieve same thing by Extension method 