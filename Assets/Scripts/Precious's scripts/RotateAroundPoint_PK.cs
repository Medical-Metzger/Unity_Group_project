using UnityEngine;

public class RotateAroundPoint_PK : MonoBehaviour
{
    public GameObject definedPoint;    // The point to rotate around
    public GameObject thingToRotate;   // The object that rotates
    public float rotationSpeed = 50f;  // Degrees per second

    void Update()
    {
        if (definedPoint != null && thingToRotate != null)
        {
            // Rotate the object around the defined point along the Y-axis
            thingToRotate.transform.RotateAround(
                definedPoint.transform.position,   // Center point
                Vector3.up,                        // Axis of rotation (Y-axis)
                rotationSpeed * Time.deltaTime     // how much time has passsed since the previous frame, smooth consistent motion, without this rotation speed would be degrees per frame not per second 
            );
        }
    }
}