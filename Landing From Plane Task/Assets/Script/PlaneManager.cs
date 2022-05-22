using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneManager : MonoBehaviour
{
    public float planeSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        transform.position += -transform.forward * Time.deltaTime * planeSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Plane"))
        {
            Debug.Log("press f");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Plane"))
        {
            Debug.Log(" destroy plane");
            Destroy(gameObject);
        }
    }
}
