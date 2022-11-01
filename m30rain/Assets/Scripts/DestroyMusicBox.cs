using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMusicBox : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "resetbox")
        {
            Destroy(this.gameObject);
        }
    }
}
