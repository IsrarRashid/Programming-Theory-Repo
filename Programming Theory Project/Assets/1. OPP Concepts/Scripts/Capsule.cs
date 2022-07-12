using TMPro;

public class Capsule : Shape    // INHERITANCE
{
    private void Start()
    {
        Name = "Capsule";
        Color = "Blue";
    }
    public override void DisplayText()   // polymorphism
    {
        DisplayArea.text = "Name: " + Name + "\nColor: " + Color;
    }
    private void OnMouseDown()
    {
        DisplayText();
    }
}
