using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongDao_Animaion : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.A))
    {
        GetComponent<Animator>().SetTrigger("ColorChange");
    }
    else if (Input.GetKeyDown(KeyCode.D))
    {
        GetComponent<Animator>().SetTrigger("Scaling");
    }
    else if (Input.GetKeyDown(KeyCode.S))
    {
        GetComponent<Animator>().SetTrigger("Spinning");
    }
    else if (Input.GetKeyDown(KeyCode.W))
    {
        GetComponent<Animator>().SetTrigger("Hover");
    }  
    }
}
