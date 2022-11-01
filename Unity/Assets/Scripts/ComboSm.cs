using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboSm : MonoBehaviour
{
    public ComboText Sm;

    void Start()
    {
        Sm = GameObject.Find("ComboCountText").GetComponent<ComboText>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Sm.Combo += 1;
        }
    }
}
