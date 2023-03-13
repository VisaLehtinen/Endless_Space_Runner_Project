using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    
    public Rigidbody2D rb;
    public float gravity;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        Input.multiTouchEnabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.gameObject != null)
        {
            player.transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * 2);
        }

    }

    public void Lift()
    {

        if (Input.touchCount > 0)
        {
            //var touch = Input.GetTouch(0);
            //rb.gravityScale = -4.314969f;
            if (player.gameObject != null)
            {
                rb.gravityScale = -gravity;
            }

        }
        //else
        //{
        //    //rb.gravityScale = 4.314969f;
        //    rb.gravityScale = gravity;
        //}
    }

    public void Descend()
    {
        if (player.gameObject != null)
        {
            rb.gravityScale = gravity;
        }

    }
}
