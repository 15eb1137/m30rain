using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMusic : MonoBehaviour
{
    private new AudioSource audio;

    [SerializeField]
    private AudioClip sound;

    private void Start()
    {
        audio = gameObject.AddComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            audio.PlayOneShot(sound);
            Destroy(gameObject, 0.2f);
        }
    }
}
