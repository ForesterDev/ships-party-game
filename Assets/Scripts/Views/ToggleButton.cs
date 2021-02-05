using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour
{
    
    public Colors GameColors;

    protected ToggleButtonsGroup buttonManager;

    private Button button;
    private TextMeshProUGUI text;
    private int index;

    void Start()
    {
        buttonManager = GetComponentInParent<ToggleButtonsGroup>();

        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);

        text = GetComponentInChildren<TextMeshProUGUI>();

        registerButton();
    }

    private void registerButton()
    {
        index = buttonManager.registerButton(this);
    }

    private void OnClick()
    {
        buttonManager.OnSelectButton(index);
    }

    public void Activate()
    {
        ChangeColor(GameColors.bgSelected);
        ChangeTextColor(GameColors.textSelected);
    }

    public void Deactivate()
    {
        ChangeColor(GameColors.bgNormal);
        ChangeTextColor(GameColors.textNormal);
    }

    private void ChangeColor (Color color)
    {
        var colors = button.colors;
        colors.normalColor = color;
        button.colors = colors;
    }

    private void ChangeTextColor (Color color)
    {
        text.color = color;
    }
}
