using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float speed_turn;
    [SerializeField] Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("w"))
        {
           Vector3 newPosition =  transform.position += new Vector3(0,0, 1) * Time.deltaTime * speed;
            animator.SetBool("Run", true);
        }
        if (Input.GetKey("a"))
        {
            Vector3 newPosition = transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * speed_turn;

            newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
            transform.position = newPosition;
            animator.SetBool("Run", true);



        }
        if (Input.GetKey("d"))
        {
            Vector3 newPosition = transform.position += new Vector3(1, 0, 0) * Time.deltaTime * speed_turn;
            newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
            transform.position = newPosition;
            animator.SetBool("Run", true);

        }
        if (Input.GetKeyUp("w"))
        {
            animator.SetBool("Run", false);
        }if (Input.GetKeyUp("a"))
        {
            animator.SetBool("Run", false);
        }if (Input.GetKeyUp("d"))
        {
            animator.SetBool("Run", false);
        }
    }
}
