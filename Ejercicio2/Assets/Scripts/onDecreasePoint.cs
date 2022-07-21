using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onDecreasePoint : MonoBehaviour
{
    // Start is called before the first frame update
    scoreManager scoreManager;
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
        this.scoreManager.decreaseScore();
        Destroy(other.gameObject);
        
    }

}
