using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    int score = 0;
    int coinsCollected;
    int livesLost = 0;

    // Start is called before the first frame update
    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void coinCollect(int coinValue)
    {
        score += coinValue;
        coinsCollected += 1;
        Debug.Log("Coins picked up: " + coinsCollected);
        Debug.Log("Score: " + score);
    }
    

    public void beeTouched(int beeValue)
    {
        score += beeValue;
        livesLost += 1;
        Debug.Log("Lives lost: " + livesLost);
        Debug.Log("Score: " + score);
    }
}
