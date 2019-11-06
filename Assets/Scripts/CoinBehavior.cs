using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinBehavior : MonoBehaviour
{
    private static int score = 0;
    public Text countText;

    void Start() {
        updateScoreText(score);
    }

    void Update() {
        
    }

    void OnTriggerEnter2D(Collider2D collision) {
        score += 1;
        updateScoreText(score);
        Destroy(gameObject);
        
    }

    private void updateScoreText(int score) {
        countText.text = "Coins: " + score.ToString();
    }
}
