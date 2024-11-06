# 1. UI Slider
1. Used to create a sliding control, often for setting values within a range (e.g., health, volume).
2. We can configure its min and max values, and handle changes through events.

#### Example 1
```csharp
using UnityEngine;
using UnityEngine.UI;

public class ScaleUsingUI : MonoBehaviour
{
    [SerializeField] private Slider sd;
  
    public void Scale()
    {
        if(sd==null) {
            Debug.Log("Null Slider");
            return;
        }
        // transform.localScale += new Vector3(value, value, value);
        transform.localScale= new Vector3(sd.value,sd.value,sd.value);
    }
}
```
#### Example 2
```csharp
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HealthController : MonoBehaviour
{
    [SerializeField] private Slider slider;
    void Start()
    {
        if (slider == null)
        {
            Debug.Log("Slider is NULL");
            return;
        }
        slider.value = 50;
        slider.interactable = false;
    }

    void Update()
    {
        if (slider == null ){
            return;
        }
        slider.value = Mathf.MoveTowards(slider.value, 100.0f, 0.1f);
    }
}
```

# 2. UI Transitions
1. Controls the appearance of UI elements when they change state (e.g., hover, click).
2. State involves such as Normal, highlighted, pressed, disabled. ( it create animation over states) 
3. Commonly used for buttons to add visual feedback during interactions by changing colors, scaling, or other properties.

# 3. UI ScrollRect
1. Allows scrolling within a defined area, usually for displaying content that's larger than the viewable area.
2. Often used in combination with a ScrollBar for better navigation within the content.
3. For this we have to add components ScrollRect and Mask to working properly.
4. We can also used Scrollbar UI component to scroll over ScrollRect object.

# 4. UI Scrollbar
1. Adds a vertical or horizontal scrollbar to your UI, usually paired with a ScrollRect.
2. Such as scrolling of websited page ( visible on botton for horizontal and visible on right side for virtical scolling)
2. Provides users with a way to scroll through content by dragging the bar or clicking on the arrows.

# 5.UI Mask
1. Restricts the visibility of child elements to fit within a defined rectangular area.
2. Useful for creating effects like cropped images, scrollable content, or dropdown menus without showing content outside the intended area.