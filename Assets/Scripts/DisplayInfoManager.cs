using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInfoManager : MonoBehaviour
{
    void OnMouseEnter()
    {
        var uiInfo = gameObject.GetComponentInParent<UIManager.IUIInfoContent>();
        UIManager.Instance.SetNewInfoContent(uiInfo);
    }

    void OnMouseExit()
    {
        UIManager.Instance.ClearInfoContent();
    }
}
