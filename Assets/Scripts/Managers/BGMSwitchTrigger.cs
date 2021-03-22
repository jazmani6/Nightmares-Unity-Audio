using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMSwitchTrigger : MonoBehaviour
{
    public WaveManager wave;
    public AudioClip newBGM;
    private BGMSelector BGM;
    // Start is called before the first frame update
    void Start()
    {
        BGM = FindObjectOfType<BGMSelector>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
    
