using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartScreen : Screen
{
    public event UnityAction StartButtonClick;

    public override void CloseScreen()
    {
        CanvasGroup.alpha = 0;
        Button.interactable = false;
    }

    public override void OpenScreen()
    {
        CanvasGroup.alpha = 1;
        Button.interactable = true;
    }

    protected override void OnButtonClick()
    {
        StartButtonClick?.Invoke();
    }
}
