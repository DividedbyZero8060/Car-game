using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{
    public float speed = 2.5f;
    private Animator animator;
    
    Vector3 targetPos = new Vector3(22.0f,-1.8f,70);
    GameObject manager;
    

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("gameManager"); 
        animator = GetComponent<Animator>();
        
        
    }

    // Update is called once per frame
    void Update()
    {

        if (animator.GetBool("isMoving"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        if (Mathf.Abs(transform.position.x - targetPos.x) < 0.1f)
        {
            animator.SetBool("isMoving", false);
            GetComponent<CharacterControllerScript>().enabled = false;
            
        }


    }

    public void Toggle()
    {
        bool flag = animator.GetBool("isMoving");
        animator.SetBool("isMoving", !flag);
    }

    public void OnTriggerEnter(Collider other)
    {
        manager.GetComponent<GameManager>().GameOver();
    }

}
