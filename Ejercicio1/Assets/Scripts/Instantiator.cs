using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject RedCube, GreenCube, BlueCube;
    Vector3 startPos = new Vector3(-14.55f, 0);
    float lastTime = 0, nextTime;
    const float minTime = 0.2f, maxTime = 1.5f, minY = -3.98f, maxY = 3.98f;

    // Start is called before the first frame update
    void Start()
    {
        nextTime = getNextTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime)
        {
            startPos.y = Random.Range(minY, maxY);
            Instantiate(nextCube(), startPos, Quaternion.identity);
            nextTime = getNextTime();
        }


    }

    float getNextTime()
    {
        return Time.time + (Random.Range(minTime, maxTime));
    }

    GameObject nextCube()
    {

        switch (Random.Range(0, 3))
        {
            case 0:
                return RedCube;
            case 1:
                return BlueCube;
            default:
                return GreenCube;
        }
    }
}
