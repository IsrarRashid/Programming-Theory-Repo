using TMPro;

public class Capsule : Shape    // INHERITANCE
{
    TextMeshProUGUI newDisplayArea;
    private void Start()
    {
        Name = "Capsule";
        Color = "Blue";
        newDisplayArea = DisplayArea;
    }
    public override void DisplayText()   // polymorphism
    {
        newDisplayArea.text = "Name: " + Name + "\nColor: " + Color + "\nweight: 60pounds";
    }
    private void OnMouseDown()
    {
        DisplayText();
    }
}
