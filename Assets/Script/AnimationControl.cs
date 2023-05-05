using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        // Get a referrence to the Animator
        anim = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Speed", Input.GetAxis("Vertical"));
        anim.SetFloat("Direction", Input.GetAxis("Horizontal"));

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Debug.Log("Horizoninput" + moveHorizontal);
        Debug.Log("Verticalinput" + moveVertical);

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.position = transform.position + movement  * Time.deltaTime;

    }
}
