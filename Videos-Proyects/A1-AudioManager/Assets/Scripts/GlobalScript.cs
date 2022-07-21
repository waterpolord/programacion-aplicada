using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScript : MonoBehaviour
{

    private void Start()
    {
        
    }
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            AudioManager.Instance.playSoundEffect(AudioManager.SoudEffect.Fire1);

        }
            
        if (Input.GetButtonDown("Fire2"))
            AudioManager.Instance.playSoundEffect(AudioManager.SoudEffect.Fire2);
        if (Input.GetButtonDown("Fire3"))
            AudioManager.Instance.playSoundEffect(AudioManager.SoudEffect.Fire1);
        if (Input.GetButtonDown("Jump"))
            AudioManager.Instance.playSoundEffect(AudioManager.SoudEffect.Jump);
    }
}
