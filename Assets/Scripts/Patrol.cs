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
        obj.velocity = new Vector2(movingRight ? -speed : speed * Time.deltaTime, obj.velocity.y);

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
        }
    }
}
