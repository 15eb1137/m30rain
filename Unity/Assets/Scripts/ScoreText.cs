using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public float Score;
    public TextMeshProUGUI ScoreCountText;

    internal static void SetScoreText()
    {
        throw new NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreCountText.text = string.Format("{0}", Score);
    }
}
