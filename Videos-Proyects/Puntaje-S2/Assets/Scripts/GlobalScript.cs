using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScript : MonoBehaviour
{

    ScoreManager scoreManager;

    private void Awake()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            scoreManager.incrementScore();
        }
        else if (Input.GetButtonDown("Fire2"))
        {
            scoreManager.decreaseScore();
        }

    }
}
