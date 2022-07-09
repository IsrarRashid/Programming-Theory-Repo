using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    [SerializeField] string _name;  // ABSTRACTION
    [SerializeField] string _color; // ABSTRACTION
    [SerializeField] TextMeshProUGUI _displayArea;  // ABSTRACTION

    private void Awake()
    {
        _name = "ShapeName";
        _color = "ShapeColor";
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
        protected set { _displayArea = value; } 
    }

    public virtual void DisplayText()
    {
        _displayArea.text = "Name: " + Name + "\nColor: " + Color;
    }
}
