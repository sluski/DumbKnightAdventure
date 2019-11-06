using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    public static Vector3 lastCheckpoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision) {
        lastCheckpoint = gameObject.transform.position;
    }

    public Vector3 GetLastCheckpoint() {
        return lastCheckpoint;
    }
}
