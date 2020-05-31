using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_Class : MonoBehaviour
{
    // When Generate Game Object, Execute this function first.
    void Awake()
    {
        Debug.Log("Ready for Player Data");
    }

    // When Game Object are activated.
    void OnEnable()
    {
        // Execute Every time when you turn on or turn off this project.
        Debug.Log("Player has been Logged in.");
    }

    // Execute this Function First Before start Update Function.
    void Start()
    {
        Debug.Log("You've got Hunting Gear.");
    }

    // Physical Operation Update
    void FixedUpdate()
    {
        // High CPU usage with fixed Frequent Execution.
        // Call this function 50 times Per Second.
        // Normally execute CPU as 50 frames, but it is executing 60 frames.
        Debug.Log("Move~!");
    }

    // Update Game Logic
    void Update()
    {
        // Dependng on the environment, The Frequent Execution Cycle can be reduced.
        Debug.Log("Hunting Monster!!");
    }

    // After all updates
    void LateUpdate()
    {
        // Upload Camera or Character Postprocessing.
        Debug.Log("You've got an extra experience point!!");
    }

    // When Game Object are disabled.
    void OnDisable()
    {
        // Execute Every time you've delete some object or all of objects.
        Debug.Log("Player Has been Logged-out.");
    }

    void OnDestroy()
    {
        // Delete All Game Objects
        Debug.Log("Released All Player Data");
    }
}
