using TMPro;

public class Cube : Shape   // INHERITANCE
{
    TextMeshProUGUI newDisplayArea;
    private void Start()
    {
        Name = "Cube";
        Color = "Red";
        newDisplayArea = DisplayArea;
    }
    public override void DisplayText()   // polymorphism
    {
        newDisplayArea.text = "Name: " + Name + "\nColor: " + Color + "\nWeight: 90pounds";
    }
    private void OnMouseDown()
    {
        DisplayText();
    }
}
