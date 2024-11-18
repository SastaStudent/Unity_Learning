[Action-Based]
# 1. Continuous Move Provider [Better]

1. The Continuous Move Provider enables smooth, uninterrupted movement of the player or XR rig in response to user input, typically from a joystick or controller.

### Properties
1. System: Links to the LocomotionSystem for controlling the player rig. Automatically searches for one if not set.
2. Move Speed: Sets the forward movement speed in units per second.
3. Enable Strafe: Enables or disables sideways movement (strafe).
4. Use Gravity: Determines whether gravity affects movement when using a CharacterController.<br>
Attempting Move: Gravity only applies when input is used for movement.<br>
Immediately: Gravity applies continuously, even without input.<br>
5. Forward Source: The transform that defines the forward movement direction (e.g., player’s camera).
6. Left Hand Move Action: Defines how movement input is handled for the left controller: <br>
Use Reference: Enables external input actions.<br>
Reference: Links to an InputAction of type Vector2Control for the left hand.<br>

7. Right Hand Move Action: Defines movement input for the right controller:<br>
Use Reference: Enables external input actions.<br>
Reference: Links to an InputAction of type Vector2Control for the right hand.<br>

### Use Case:
1. Ideal for VR applications where smooth navigation is necessary, such as exploration or adventure games.
2. May cause motion sickness for some VR users due to the disconnect between real-world and virtual movement.

# 2. Dynamic Move Provider
The Dynamic Move Provider extends the functionality of the Continuous Move Provider by offering more complex input handling. It allows movement to be influenced by multiple input sources simultaneously, such as hand gestures, head movement, or multiple joysticks.

### Key Features:
1. Multi-Input Support: Can combine inputs from various sources (e.g., head direction and joystick tilt).
2. Head-Relative Movement: Movement direction can align with the direction the user is looking.
3. Enhanced Customization: Provides more control over how inputs are combined or prioritized.

### Use Case:
1. Best suited for advanced VR applications where movement needs to adapt to multiple input methods.
2. Common in immersive experiences requiring a high degree of player control or flexibility, such as flight simulators or games with unique locomotion mechanics.


# 3. Continuous Turn Provider 
### Description: 
The player smoothly rotates their view or character when they input a turn command (e.g., via joystick or keyboard).

### Advantages:
1. Feels natural and immersive, especially in non-VR applications.
2. Mimics real-world turning for a seamless experience.
3. Works well in games where immersion is key.

### Disadvantages:
1. In VR, it can cause motion sickness for some players due to the disconnect between their physical body and virtual rotation.
2. Precision turning can sometimes be harder.
### Use Case: 
Non-VR games, immersive VR games where motion sickness is less of a concern (or optional settings).

# 4. Snap Turn Provider [Better]
### Description: 
The player’s view or character rotates by a fixed angle (e.g., 45° or 90°) instantly when a turn input is given.

### Advantages:
1. Greatly reduces motion sickness in VR since the change is abrupt, without causing the feeling of artificial motion.
2. Precise control over rotational steps.

### Disadvantages:
1. Less immersive due to the abrupt transitions.
2. May feel unnatural for some players in non-VR applications.

### Use Case: 
VR games where comfort and accessibility are prioritized.

### Properties
1. System: The LocomotionSystem that this LocomotionProvider communicates with for exclusive access to an XR Origin. If one is not provided, the behavior will attempt to locate one during its Awake call.
2. Turn Amount: The number of degrees clockwise Unity rotates the rig when snap turning clockwise.
3. Debounce Time: The amount of time that Unity waits before starting another snap turn.
4. Enable Turn Left Right: Controls whether to enable left and right snap turns.
5. Enable Turn Around: Controls whether to enable 180° snap turns.

# Note 1:-
(if moving with left hand, in turn use right hand or vice versa).

# 5. Character Controller
The Character Controller is mainly used for third-person or first-person player control that does not make use of Rigidbody physics.

1. Slope Limit: Determines the maximum steepness (in degrees) of slopes the character can climb. Steeper slopes are not allowed.
2. Step Offset: Defines how high a step the character can climb (in units). The character will step up if the surface is lower than this value.
3. Skin Width: The distance two colliders can penetrate each other. A larger value reduces jitter but may cause characters to get stuck. Set around 10% of the collider's radius for optimal performance.
4. Min Move Distance: Prevents the character from moving if the movement distance is below this value. Useful for reducing small movements or jitter. Typically set to 0.
5. Center: Offsets the position of the character’s collider (capsule) in world space without affecting its pivot point.
6. Radius: Controls the width of the capsule collider (measured across the X and Z axes).
7. Height: Controls the height of the capsule collider (along the Y axis). Changing this affects the character’s collision bounds vertically.

# 6. XR Interaction Group
An XR Interaction Group is a component that manages interactions for multiple Interactors (such as controllers or hands in VR). It ensures that only one Interactor can interact (hover or select) at a time, based on a priority system.

### Key Features:
1. Priority-Based: Interactors within the group are sorted by priority. The one with the highest priority is selected for interaction.
2. Continuous Selection: If an Interactor was interacting in the previous frame, it takes priority to continue interacting, even if a higher-priority Interactor is now available.
3. Nested Groups: Groups can contain other groups, and a nested group is treated as a single Interactor when considering priority. The selected Interactor within a nested group is passed up to the parent group for final interaction selection.