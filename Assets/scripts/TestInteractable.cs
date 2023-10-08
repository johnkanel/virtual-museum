using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestInteractable : Interactable
{
    public GameObject panel;
    public override void OnFocus()
    {

    }

    public override void onInteract()
    {
        panel.SetActive(true);
    }

    public override void onLoseFocus()
    {

    }

    public override void stopInteract()
    {
        panel.SetActive(false);
    }
}
