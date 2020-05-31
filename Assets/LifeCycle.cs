using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Start()
    {
        // int number = 4; // This Simple Number Call Scala. Scala Value
    }

    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"), 
            0); // Vector Value

        // A function that adds a vector value to the current position.
        transform.Translate(vec);
    }

    // Example_Class ex_code = new Example_Class();
    
    public void InputKey() {
        // It alway shows True when receive any input. Keep Inputing
        if (Input.anyKey)
            Debug.Log("Player Inputing Any Key");

        // When User Started to Input Any Keyboard first.
        // Return means Enter Key.
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("You've bought Item.");

        // It alway shows True when receive any Keyboard Input.
        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("Move to Left Side.");

        // When User Stopped to Input Any Keyboard finally.
        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("It stopped to move to Right Side.");
    }

    public void InputMouseEvent() {
        // When User Started to Input Mouse Input Event first.
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Launch Missile!");

        // It alway shows True when receive any Mouse Input Event.
        if (Input.GetMouseButton(0))
            Debug.Log("Collecting Missiles..");

        // When User Stopped to Input Mouse Event finally.
        if (Input.GetMouseButtonUp(0))
            Debug.Log("Launch Super Missiles!!");
    }

    public void InputButton() {
        // When User Started to Input "Input Button" first, it shows true.
        if (Input.GetButtonDown("SuperFire"))
            Debug.Log("Lethal Moves!");

        // Keep Executing when user Keep Inputing.
        if (Input.GetButton("Fire1"))
            Debug.Log("Collecting Jump...");

        // When User Stopped to Input "Input Button" finally, it stops Input Program.
        if (Input.GetButtonUp("Fire1"))
            Debug.Log("Super Jump!!!");
    }

    public void InputButtonUpdate()
    {
        // When User Inputed Any Key first. Show When user started to input Keyboard.
        if (Input.anyKeyDown)
            Debug.Log("Player Inputed Any Key.");

        if (Input.GetButton("Horizontal"))
        {
            // When User Input Horizontal or Vertical Button, it shows float.
            // Object always have Transform Variable.
            Debug.Log("Moving Laterally...."
                // + Input.GetAxis("Horizontal"));
                + Input.GetAxisRaw("Horizontal"));

        }

        if (Input.GetButton("Vertical"))
        {
            Debug.Log("Moving Laterally...."
                // + Input.GetAxis("Vertical"));
                + Input.GetAxisRaw("Vertical"));
        }
    }
}
