using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    Vector3 deltaPos = new Vector3(-0.05f, -8.12f),speedP = new Vector3();
    float speedX = 0.5f,minLimitX = -19.28f,maxLimitX = 19.28f;
    public GameObject projectile;
    public TextMesh scoreTXT;
    int currentScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreTXT.text = currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        deltaPos.x = Input.GetAxis("Horizontal") * speedX;
        gameObject.transform.Translate(deltaPos);
        gameObject.transform.position = new Vector3(
               Mathf.Clamp(gameObject.transform.position.x, minLimitX, maxLimitX),
               -8.12f,
               gameObject.transform.position.z
           );
        if (Input.GetButtonDown("Jump"))
        {
            speedP = gameObject.transform.position;
            //speedP.y *= speedPY;
  
            Instantiate(projectile, speedP, Quaternion.identity);
        }
        
    }

    public void incrementScore()
    {
        currentScore++;
        scoreTXT.text = currentScore.ToString();
    }

    
}
