using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightOutline : MonoBehaviour
{
    private Outline outlineComponent;

    void Start()
    {
        outlineComponent = GetComponent<Outline>();    
    }

    void OnMouseEnter()
    {
        outlineComponent.enabled = true;
    }

    void OnMouseExit()
    {
        outlineComponent.enabled = false;
    }
}
