using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePopup : MonoBehaviour
{
    public void ClosePopupOnClick()
    {
        gameObject.transform.parent.gameObject.SetActive(false);
        
    }
}
