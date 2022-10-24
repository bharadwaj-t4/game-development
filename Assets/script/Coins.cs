using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{

    private int score=0;
    public Text scoreText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("coin"))
        {
            score++;
            Debug.Log(score);
            Destroy(collision.gameObject);
            scoreText.text = "Score : "+ score;
        }
    }

}
