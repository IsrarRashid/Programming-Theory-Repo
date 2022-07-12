using TMPro;

public class Cube : Shape   // INHERITANCE
{
    private void Start()
    {
        Name = "Cube";
        Color = "Red";
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
