using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicboxSlide : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        Transform tf = this.transform;
        Vector3 pos = tf.position;
        pos.z -= 0.08f;
        tf.position = pos;
    }
}
