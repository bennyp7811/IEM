using UnityEngine;

public class ButtonScript : MonoBehaviour 
{
    public int buttonNumber;
    public ColePuzzleManager puzzle;

    public void Press()
    {
        puzzle.PressButton(buttonNumber);
    }
}
