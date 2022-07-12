using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// ABSTRACTION
public abstract class Shape : MonoBehaviour
{
    [SerializeField] string _name;
    [SerializeField] string _color;
    [SerializeField] TextMeshProUGUI _displayArea;

    private void Awake()    // this method will invoke even if this script is not present in hierarchy
    {
        DisplayArea = GameObject.Find("Display Text").GetComponent<TextMeshProUGUI>();
    }

    // ENCAPSULATION
    public string Name
    {
        get { return _name; }

        set { _name = value; } 
    }

    // ENCAPSULATION
    public string Color
    {
        get { return _color; }

        set { _color = value; }
    }

    // ENCAPSULATION
    public TextMeshProUGUI DisplayArea 
    { 
        get { return _displayArea; }
        set { _displayArea = value; } 
    }

    public abstract void DisplayText();
}
