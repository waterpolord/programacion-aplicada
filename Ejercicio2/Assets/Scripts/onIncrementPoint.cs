using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onIncrementPoint : MonoBehaviour
{
    scoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<scoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        this.scoreManager.incrementScore();
        Destroy(other.gameObject);

    }
}
