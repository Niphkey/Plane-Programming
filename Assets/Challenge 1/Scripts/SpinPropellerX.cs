using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float angularSpeed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotates plane propeller around the Z axis at constant speed
        transform.Rotate(Vector3.forward, angularSpeed);
    }
}
