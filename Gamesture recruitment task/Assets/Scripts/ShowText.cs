using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    private Button showTextButton;
    private Text buttonText;
    private string baseText;
    private string swapText="Piotr Pochopien";
    private const int TIME_AFTER_MAKE_CHANGE = 3;

    private void Awake()
    {
        showTextButton = GetComponent<Button>();
        buttonText=GetComponentInChildren<Text>();
        baseText = buttonText.text;
        if (showTextButton == null)
        {
            Debug.LogError("Can't find button component",showTextButton);
        }
        if (buttonText == null)
        {
            Debug.LogError("Can't find text component",buttonText);
        }
    }

   public void ShowTextButtonClick()
    {
        buttonText.text = swapText;
        ChangeButtonInteractable();
        StartCoroutine(ChangeTextToBase());
    }

    IEnumerator ChangeTextToBase()
    {
        yield return new WaitForSeconds(TIME_AFTER_MAKE_CHANGE);
        ChangeButtonInteractable();
        buttonText.text = baseText;
    }

    void ChangeButtonInteractable()
    {
        showTextButton.interactable = !showTextButton.interactable;
    }
}
