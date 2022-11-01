using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowResult : MonoBehaviour
{
    void Start()
    {
        this.gameObject.SetActive(false);
        Invoke("Open", 96); // 曲が終わる秒数
    }
    void Open()
    {
        this.gameObject.SetActive(true);
    }
}
