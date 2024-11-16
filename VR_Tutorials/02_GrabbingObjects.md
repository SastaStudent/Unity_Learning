# Grabbing Objects in VR (Unity)
1. Add XR Direct Intractor Component to the Left and Right Hand Controller.
2. Add a Collider as Trigger to the hand Controllers.
3. Add XR Grab Interaction to that components, that was intented to Grab interaction.
4. Always check colliders attached to the Game Objects.

## Note:
1. We can also set attach point :- From where component will be grabbed.
2. By default it set to the center of the game object.
3. For this we have to create an empty game object and give a position and add to the game object.
4. Also attach this game object to the XR Grab Interaction componenet ( Present at bottom side) [Attach Transform].


# 1. XR DIRECT INTERACTOR ATTRIBUTES
### 1. Interaction Manager –
This manager is in charge of all interactions between the interactable object and the XR Direct Interactor. If there is one in the scene, the XR Direct Interactor will automatically assign itself to it. You can have multiple Interaction Managers if you wanted to customize certain interactions, but I haven’t found a good use case for this yet.

### 2. Interaction Layer Mask –
If you want to have only certain objects be interactable, you would use this layer mask to set that up. The default setting is to allow all interactable objects

### 3. Attach Transform –
This is the Transform that an interactable object will attach to. If you don’t set one, it’ll use the XR Direct Interactor’s transform by default.

### 4. Select Action Trigger –
To determine how the Select Action is triggered, you use this. The Select Action can be done in four ways. By default it is by current state. It can also be based off state change, toggle (when the select button is pressed), and stick toggle (it is activated when the select button is pressed and deselected when the select button is depressed a second time).

### 5. Hide Controller on Select –
Toggling this will hide the hand prefab when you select an object. This is great for getting around having to make proper attach points for every object in your Scene.

### 6. Allow Hovered Activate –
This sends out a activate and deactivate event to the interactable object when hovered over.

### 7. Sound, Haptic, and Interactor Events –
These events can be used to provide feedback for the player. Interactor Events are things like Hover Enter/Exit and Select Enter/Exit. The Audio and Haptic events will allow you to determine how much vibration to send to a controller or play a sound when something is selected.

# XR GRAB INTERACTABLE MOVEMENT TYPES
### 1. Instantaneous –
This type will move with your hand when you grab the object without any physics. It actually disables the Rigibody when you are holding the object so it will clip through anything. 

### 2. Kinematic –  
This type will give a movement delay and be influenced by your hand’s physics. It is able to pass through objects that do not have a Rigidbody when held, but will collide with them when it is not held. 

### 3. Velocity Tracking –  
This one also has a delay in tracking as it’s simulating force being added to a handheld object. When holding it, it will collide with all objects even if they do not have a Rigidbody. It’s great for simulating physics with a door or cabinet object or bowling ball.

# 2. XR GRAB INTERACTABLE ATTRIBUTES

1. The XR Grab Interactable component doesn’t just stop at movement types when it comes to customization. 
2. Here I will list some important attributes that will help make you grabbable objects more fine tuned for whatever you’re building.

### 1. Interaction Layer Mask –  
This can be used to assign your objects to different interaction layer masks. An example would be preventing an object from interacting with the player body causing unwanted collisions.

### 2. Colliders – 
These can be used as an array of colliders to add to our interactable game object if one collider is not enough.

### 3. Track Position –  
This determines if an object should track the position of the thing grabbing it. You might want to turn this off if you were only interested in the rotation of the object relative to the hand grabbing it.

### 4. Smooth Position – 
When checked, this will allow you to smooth out the movement of the object in hand. This is great for simulating weight of an object.

### 5. Track Rotation –  
This is great for  toggling on or off if you want to follow the hands rotation or ignore it. 

### 6. Smooth Rotation –  
Just like smooth position, this will smooth out the rotation of the hand when played with.

### 7. Throw on Detach – 
This can help stop the object from being thrown if that isn’t desired from the player. If toggled on, you can change various attributes such as velocity scale to alter how the object acts one released from the player’s hand.

### 8. Attach Ease In Time –  
When grabbing the  object, this will determine the time it takes to attach to your hand. It produces a very cool floating towards your hand over the set period of time.

### 9. Intractable Events -
Apart from that to inhance VR experiance we can intractable Events, Such as
1. Hover & (Variety of hover)
2. Select & (Variety of Select)
3. Focus & (Variety of Focus) etc.
