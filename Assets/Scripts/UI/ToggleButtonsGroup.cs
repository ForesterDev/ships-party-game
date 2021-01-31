using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButtonsGroup : MonoBehaviour
{
    protected ArrayList toggleButtons;

    private void Awake()
    {
        toggleButtons = new ArrayList();
    }

    public int registerButton (ToggleButton b)
    {
        int index = this.toggleButtons.Add(b);
        return index;
    }

    public void OnSelectButton(int index)
    {
        for (int i = 0; i < this.toggleButtons.Count; i++)
        {
            ToggleButton tb = (ToggleButton) this.toggleButtons[i];
            if (index == i)
            {
                tb.Activate();
            } else
            {
                tb.Deactivate();
            }
        }
    }
}
