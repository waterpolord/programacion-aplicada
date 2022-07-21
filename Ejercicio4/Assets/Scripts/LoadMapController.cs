using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadMapController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject T1, T2, T3, T4, T5, T6, T7, T8;
    public GameObject F1, F2, F3, F4, F5, F6, F7,F8,F9,F10;
    public GameObject enemy1;
    private float x = 0.0f, y = 0.0f, minLimitY = 0.49f, maxLimitY = 35.19f,
       minLimitX = 0.21f, maxLimitX = 100f;
    Dictionary<string, GameObject> keys = new Dictionary<string, GameObject>();
    void Start()
    {
        //Instantiate Trees
        keys.Add("T1", T1);
        keys.Add("T2", T2);
        keys.Add("T3", T3);
        keys.Add("T4", T4);
        keys.Add("T5", T5);
        keys.Add("T6", T6);
        keys.Add("T7", T7);
        keys.Add("T8", T8);
        //Instantiate Floor
        keys.Add("F1", F1);
        keys.Add("F2", F2);
        keys.Add("F3", F3);
        keys.Add("F4", F4);
        keys.Add("F5", F5);
        keys.Add("F6", F6);
        keys.Add("F7", F7);
        keys.Add("F8", F8);
        keys.Add("F9", F9);
        keys.Add("F10", F10);
        var layer1 = File.ReadAllText("D:\\Carpeta de clases\\Actual\\Programacion-Aplicada\\Assets\\L1.csv").Replace("\r", ",").Replace("\n", ",").Split(",");
        
        
        int ind = 0;
        float lastX = 0f;
        foreach(string sprite in layer1)
        {
            

            if (keys.ContainsKey(sprite))
            {
                Instantiate(keys[sprite], new Vector3(x, y),
                    Quaternion.identity);
                x = ind % 100;
                y = ind / 100;
                ind++;    
            }
        

        }

        for (int i = 0; i < 20; i++)
        {
            x = Random.Range(minLimitX, maxLimitX);
            y = Random.Range(minLimitY, maxLimitY);
            Instantiate(enemy1, new Vector3(x, y,-2),
                    Quaternion.identity);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject nextEnemy()
    {

        switch (Random.Range(0, 8))
        {
            case 0:
                return T8;
            case 1:
                return enemy1;
            case 2:
                return null;
            case 3:
                return null;
            case 4:
                return null;
            case 5:
                return null;
            case 6:
                return null;
            default:
                return null;
        }
    }
}
