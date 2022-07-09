using TMPro;

public class Sphere : Shape // INHERITANCE
{
    TextMeshProUGUI newDisplayArea;
    private void Start()
    {
        Name = "Sphere";
        Color = "Green";
        newDisplayArea = DisplayArea;
    }
    public override void DisplayText()   // polymorphism
    {
        newDisplayArea.text = "Name: " + Name + "\nColor: " + Color + "\nWeight: 30pounds";
    }
    private void OnMouseDown()
    {
        DisplayText();
    }
}
