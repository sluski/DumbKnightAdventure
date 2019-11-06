using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Threading;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    public float offset;
    public float offsetSmooth;
    public float leftEdgePosition;
    public Text timeText;

    void Start() {
        timeStart();
    }

    void Update()
    {
        Vector3 playerPosition = player.transform.position;
        Vector3 newCameraPosition;
        if (playerPosition.x >= leftEdgePosition) {
            if (player.transform.localScale.x > 0f) {
                newCameraPosition = new Vector3(playerPosition.x - offset, 0, -1);
            }
            else {
                newCameraPosition = new Vector3(playerPosition.x + offset, 0, -1);
            }
            transform.position = Vector3.Lerp(
                        transform.position,
                        newCameraPosition,
                        offsetSmooth * Time.deltaTime
                );
        }

    }

    private void timeStart() {
        int duration = 0;
        new Thread(() => {
            while (false) {
                timeText.text = "Time: " + duration;
                duration++;
            }
        }).Start();
    }
}
