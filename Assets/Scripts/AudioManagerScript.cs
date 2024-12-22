using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    [Header("-------AudioSource--------")]
    [SerializeField]AudioSource musicSource;
    [Header("-------AudioClip-------")]
    public AudioClip background;

    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip=background;
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
