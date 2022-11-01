using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetComboSm : MonoBehaviour
{
    public ComboText Sm;

    void Start()
    {
        Sm = GameObject.Find("ComboCountText").GetComponent<ComboText>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "resetbox")
        {
            Sm.Combo = 0;
        }
    }

}
