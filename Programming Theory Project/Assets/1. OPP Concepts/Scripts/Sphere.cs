using TMPro;

public class Sphere : Shape // INHERITANCE
{
    private void Start()
    {
        Name = "Sphere";
        Color = "Green";
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
