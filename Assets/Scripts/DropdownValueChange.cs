using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DropdownValueChange : MonoBehaviour
{

    public Dropdown dropdown;
    public Canvas view1;
    public Canvas view2;

    public void Start()
    {
        dropdown.onValueChanged.AddListener(delegate { ValueChangeCheck(); });

    }

    public void ValueChangeCheck()
    {
        if (dropdown.value == 0)
        {
            view1.enabled = true;
            view2.enabled = false;
            
        }
        else
        {
            view1.enabled = false;
            view2.enabled = true;
        }
    }
}
