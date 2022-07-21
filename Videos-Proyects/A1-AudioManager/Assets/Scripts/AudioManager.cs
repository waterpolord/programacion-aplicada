using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public enum SoudEffect
    {
        Fire1,
        Fire2,
        Fire3,
        Jump
    }

    public AudioSource fire1;
    public AudioSource fire2;
    public AudioSource fire3;
    public AudioSource jump;

    public static AudioManager Instance;

    private void Awake()
    {
        Instance = this;
    }




    public void playSoundEffect(SoudEffect soudEffect)
    {
        switch (soudEffect)
        {
            case SoudEffect.Fire1:
                fire1.Play();
                break;
            case SoudEffect.Fire2:
                fire2.Play();
                break;
            case SoudEffect.Fire3:
                fire3.Play();
                break;
            case SoudEffect.Jump:
                jump.Play();
                break;
        }
    }
}
