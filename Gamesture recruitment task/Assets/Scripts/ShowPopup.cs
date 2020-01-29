using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPopup : MonoBehaviour
{
    [SerializeField] private GameObject popup;

    private void Awake()
    {
        if (popup == null)
        {
            Debug.LogError("Popup plane don't added",popup);
        }
    }

    public void ShowPopupOnClick()
    {
        popup.SetActive(true);
    }
}
