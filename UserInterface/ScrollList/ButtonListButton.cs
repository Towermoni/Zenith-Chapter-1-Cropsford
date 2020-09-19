﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonListButton : MonoBehaviour
{
    [SerializeField]
    private Text myText;
    [SerializeField]
    private ButtonListControl buttonControl;

    private string myTextString;

    public void setText(string textString)
    {
        myTextString = textString;
        myText.text = textString;
    }

    public void onClick()
    {
        buttonControl.buttonClick(myTextString);
    }
}
