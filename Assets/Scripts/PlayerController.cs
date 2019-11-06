using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpSpeed = 7f;
    private float movement = 0;
    private Rigidbody2D playerRB;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTochingGround;
    private Animator playerAnimator;
    public Text lifesText;

    private int lifes = 3;

    void Start() {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        updateLifesText();
    }

    void Update() {
        isTochingGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
        movement = Input.GetAxis("Horizontal");
        if (movement != 0) {
            playerRB.velocity = new Vector2(movement * speed, playerRB.velocity.y);
            if (movement > 0) {
                transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
            }
            else {
                transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
            }
        }
        if (Input.GetButtonDown("Jump") && isTochingGround) {
            playerRB.velocity = new Vector2(playerRB.velocity.x, jumpSpeed);
        }
        playerAnimator.SetFloat("Speed", movement > 0 ? movement : -movement);
    }

    public void Die() {
        Debug.Log("Die");
        gameObject.transform.position = CheckpointController.lastCheckpoint;
        lifes--;
        updateLifesText();
    }

    private void updateLifesText() {
        lifesText.text = "Lifes: " + lifes.ToString();
    }
}
