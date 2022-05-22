using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundManager : MonoBehaviour
{
    public PlayerController pc;
    public bool isGrounded = false;

    // Start is called before the first frame update
    void Awake()
    {
        pc = GameObject.Find("Soldier").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {            
          // pc.openChute.SetActive(false);
           isGrounded = true;
         
        }

        GameOver();
    }

    public void GameOver()
    {
        if(!pc.openChute.activeInHierarchy && isGrounded == true)
        {
            Debug.Log(" you lose gameover");
            SceneManager.LoadScene("Lose");
        }

        if(pc.openChute.activeInHierarchy && isGrounded == true)
        {
            Debug.Log("you win but gameover");
            SceneManager.LoadScene("Win");
        }
    }
}


