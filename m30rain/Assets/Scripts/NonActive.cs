using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonActive : MonoBehaviour
{
    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        this.gameObject.SetActive(false);
    }
}
