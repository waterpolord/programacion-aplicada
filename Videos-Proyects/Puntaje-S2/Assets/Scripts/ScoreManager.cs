using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    int currentScore = 0;
    public TextMesh scoreTXT;
    // Start is called before the first frame update
    void Start()
    {
        scoreTXT.text = currentScore.ToString();
    }

    // Update is called once per frame
    public void incrementScore()
    {
        currentScore++;
        scoreTXT.text = currentScore.ToString();
    }

    public void decreaseScore()
    {
        currentScore--;
        scoreTXT.text = currentScore.ToString();
    }



}
