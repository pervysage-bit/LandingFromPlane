using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform targetPlane;
    public Vector3 offset;
    public float smoothSpeed = 0.12f;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 desiredPosition = targetPlane.position + offset;
        Vector3 soothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = soothPosition;
    }
}
