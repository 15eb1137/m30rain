using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGaugeManager : MonoBehaviour
{
    public Slider ScoreGauge;

    void Start()
    {
        ScoreGauge = GameObject.Find("ScoreGauge").GetComponent<Slider>();
        ScoreGauge.value = 0;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            ScoreGauge.value += 0.008f;
        }
    }
}
