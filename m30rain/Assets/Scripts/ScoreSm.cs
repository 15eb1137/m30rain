using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSm : MonoBehaviour
{
    public ScoreText Sm;

    void Start()
    {
        Sm = GameObject.Find("ScoreCountText").GetComponent<ScoreText>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Sm.Score += 20;
        }
    }
}
