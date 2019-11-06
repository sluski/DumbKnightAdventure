using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetectorController : MonoBehaviour
{

    public GameObject player;
    private PlayerController playerController;

    void Start()
    {
        playerController = player.GetComponent<PlayerController>();
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision) {
        playerController.Die();
    }
}
