using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCarRotation : MonoBehaviour
{
    public Transform carTransform; // Reference to the car's Transform component

    // Update is called once per frame
    void Update()
    {
        // Check if the carTransform is not null
        if (carTransform != null)
        {
            // Set the camera's rotation to match the car's rotation
            transform.rotation = carTransform.rotation;
        }
    }
}
