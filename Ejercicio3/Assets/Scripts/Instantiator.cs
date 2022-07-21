using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject RedCube, GreenCube, BlueCube, squareColor,speed,life;

    Vector3 startPos = new Vector3(-14.55f, 0);
    Vector2 enemyPos = new Vector2();
    Vector2 enemySpeed = new Vector2(15, 0);
    public Material blue, red, green;
    float nextTime;
    const float minTime = 0.2f, maxTime = 1.5f, minY = -3.98f, maxY = 3.98f;

    // Start is called before the first frame update
    void Start()
    {
        nextTime = getNextTime();
        
        
        

    }

    // Update is called once per frame
    void Update()
    {
        enemyPos.x = enemySpeed.x * Time.deltaTime;

        if (Time.time > nextTime)
        {
            
            startPos.y = Random.Range(minY, maxY);
            Instantiate(nextObject(), startPos, Quaternion.identity);
                
            
            
            nextTime = getNextTime();
        }

    }



    float getNextTime()
    {
        return Time.time + (Random.Range(minTime, maxTime));
    }

    GameObject nextObject()
    {

        switch (Random.Range(0, 5))
        {
            case 0:
                return RedCube;
            case 1:
                return BlueCube;
            case 2:
                return speed;
            case 3:
                return life;
            case 4:
                squareColor.GetComponent<MeshRenderer>().material = selectColor();
                return squareColor;
            default:
                return GreenCube;
        }
    }

    private Material selectColor()
    {
        switch (Random.Range(0, 3))
        {
            case 0:
                return red;
            case 1:
                return blue;
            default:
                return green;
        }
    }
}
