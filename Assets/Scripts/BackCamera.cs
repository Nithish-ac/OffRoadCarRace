using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackCamera : MonoBehaviour
{
    public Transform carTransform;  // Reference to the car's transform
    [Range(1, 10)]
    public float followSpeed = 2;  // Smoothing speed for the camera position
    [Range(1, 10)]
    public float lookSpeed = 5;  // Smoothing speed for the camera rotation
    public Vector3 offset = new Vector3(0, 5, -10);  // Offset from the car's position

    private Vector3 velocity = Vector3.zero;  // Used for smooth damping

    void FixedUpdate()
    {
        if (carTransform == null)
            return;

        // Calculate the desired position based on the car's position and rotation
        Vector3 desiredPosition = carTransform.TransformPoint(offset);
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, followSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        // Smoothly rotate the camera to look at the car's direction
        Quaternion desiredRotation = Quaternion.LookRotation(carTransform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, lookSpeed * Time.deltaTime);
    }
}