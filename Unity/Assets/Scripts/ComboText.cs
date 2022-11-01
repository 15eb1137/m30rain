using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComboText : MonoBehaviour
{
    public float Combo;
    public TextMeshProUGUI ComboCountText;

    internal static void SetComboText()
    {
        throw new NotImplementedException();
    }

    void Start()
    {
        Combo = 0;
    }

    void Update()
    {
        ComboCountText.text = string.Format("{0}", Combo);
    }
}
