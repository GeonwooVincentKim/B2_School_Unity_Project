using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Translate means Multiplies to Vector.
        // Vector Function : Multiplies Vector Function to Time Parameter.
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime
        );
        transform.Translate(vec);
    }
}
