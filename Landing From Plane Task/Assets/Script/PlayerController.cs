using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private CapsuleCollider cc;
    private Animator anim;

    public GameObject plane;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject openChute;
  
   
    //public float fallSpeed;


    void Start()
    {     
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        cc = GetComponent<CapsuleCollider>();

        rb.useGravity = false;
        cc.isTrigger = true;
        cam1.SetActive(true);
        cam2.SetActive(false);

        openChute.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        PlayerDropFromPlane();
        OpenChute();
    }

    public void PlayerDropFromPlane()
    {
        if(anim != null)
        {
            if (Input.GetKeyDown(KeyCode.L))
            {

                Transform childToRemove = plane.transform.Find("Soldier");
                childToRemove.parent = null;

                rb.useGravity = true;
                cc.isTrigger = false;
                cam1.SetActive(false);
                cam2.SetActive(true);
                anim.SetBool("flyAnim", true);

                if (!openChute.activeInHierarchy)
                {
                    LoseCondition();
                }
            }
        }
     
    }

    public void OpenChute()
    {
        // Debug.Log("press P to open parachute");

        if (Input.GetKeyDown(KeyCode.P))
        {
            openChute.SetActive(true);
            rb.drag = 2;
            anim.SetBool("flyAnim", false);

           if(openChute.activeInHierarchy)
           {
                WinCondition();
           }
           
        }

    }

     void LoseCondition()
    {
        Debug.Log("you will lose open parachute");
                     
    }

    void WinCondition()
    {

        Debug.Log("You win");

    }

}