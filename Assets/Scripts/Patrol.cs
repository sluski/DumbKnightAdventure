using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public float distance = 5f;
    private bool movingRight;
    public Transform groundDetector;
    private Rigidbody2D obj;
    void Start()
    {
        obj = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
            
            //transform.localScale = new Vector3(0.2f, transform.localScale.y, transform.localScale.z);
            transform.Translate(new Vector3(distance * Time.deltaTime, 0, 0));
        //if()

            /*transform.localScale = new Vector3(-0.2f, transform.localScale.y, transform.localScale.z);
            transform.Translate(new Vector3(-distance * Time.deltaTime, 0, 0));*/
            
        /*obj.velocity = new Vector2(movingRight ? -speed : speed * Time.deltaTime, obj.velocity.y);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetector.position, Vector2.down, distance);
        if (groundInfo.collider == false) {
            if (movingRight) {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }*/
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (transform.rotation.y == 0)
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
            transform.Translate(new Vector3(-distance * Time.deltaTime, 0, 0));
        }
        else
        {
            transform.eulerAngles = new Vector3(0, -0, 0);
            transform.Translate(new Vector3(-distance * Time.deltaTime, 0, 0));
        }
    }
}
