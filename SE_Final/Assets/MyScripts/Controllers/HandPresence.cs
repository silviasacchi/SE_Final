//I created this script by following the tutorial available at this link: https://www.youtube.com/watch?v=VdT0zMcggTQ
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class HandPresence : MonoBehaviour
{
    public InputDevice targetDevice;

    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>(); // Create a list to store InputDevice objects representing input controllers
        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller; // Create a variable to store the characteristics of the right controller
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices); // Populate the list with InputDevice objects representing right input controllers

        foreach (var item in devices) // Iterate through the list of InputDevice objects
        {
            Debug.Log(item.name + item.characteristics); // Print the name and characteristics of each InputDevice object
        }
        if (devices.Count > 0) // Check if the list of InputDevice objects is not empty
        {
        targetDevice = devices[0]; // Set the targetDevice variable to the first InputDevice object in the list
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        if (targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue) && primaryButtonValue) // Check if the primary button is pressed
            Debug.Log("Pressing primary button"); // Print a message to the console

        if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue) && triggerValue > 0.1f) // Check if the trigger is pressed
            Debug.Log("Trigger pressed " + triggerValue); // Print a message to the console

        if (targetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxisValue) && primary2DAxisValue != Vector2.zero) // Check if the primary 2D axis is not at the center
            Debug.Log("Primary Touchpad " + primary2DAxisValue); // Print a message to the console
    }
}
