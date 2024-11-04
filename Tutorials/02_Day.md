# Game Object and Components

1. Game Object :- Eveary Object that are used in the game is a GameObject.

2. Components :- To give functionality to a GameObject, we attach different components to it. Even our scripts are components. So we can say, components are isolated functionality that can be attached to an object to give that functionality to that particular object. That means, when an object requires a specific type of functionality, you add the relevant component.

3. Conclude :- 
A GameObject is like a container for many different components. By default, all GameObject automatically have a Transform component. This is because the Transform defines where the GameObject is located and how it is rotated and scaled. Without a Transform component, the GameObject would not have a location in the world

# Prefabs

(i) Prefabs are a special type of component that allows fully configured GameObjects to be saved in the Project for reuse. These assets can then be shared between scenes, or even other projects without having to be configured again. This is quite useful for objects that will be used many times, such as platforms.

(ii) A major benefit to Prefabs is that they are essentially linked copies of the asset that exist in the Project window. This means that changes made or applied to the original Prefab will be propagated to all other instances. This makes fixing object errors, swapping out art or making other stylistic changes very efficient.

(iii) Prefabs are created automatically when an object is dragged from the Hierarchy into the Project window.

(iv) Prefabs look quite similar to other objects that appear in the Project window. However, when selected, their file type will be a *.prefab. When the Prefab is selected, the Inspector displays all of the components that were configured on the original object.

# Tags

1. Tags are referance word which is assign to one or more GameObjects.
2. It is used to identify the GameObjects and apply thing like component
3. It is also categorize the similar type of GameObject

# Layer

1. Layers are a tool that allows you to separate GameObjects in our scenes
2.  You can use layers through the UI and with scripts to edit how GameObjects within your scene interact with each other.