using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyText : MonoBehaviour
{
    public static int keys;
    private Text _text;
    
    // Start is called before the first frame update
    void Start()
    {
        keys = 0;
        _text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = keys.ToString();
    }
}
