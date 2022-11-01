using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public void PointerDown()
    {
        this.gameObject.SetActive(true);
    }

    public void PointerUp()
    {
        this.gameObject.SetActive(false);
    }
}
