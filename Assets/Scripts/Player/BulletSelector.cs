using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSelector : MonoBehaviour
{
    public AudioSource gunSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchGun(AudioClip gun)
    {
        gunSound.clip = gun;
    }
}
