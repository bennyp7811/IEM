using UnityEngine;

public class ColePuzzleManager : MonoBehaviour
{
    public int[] correctOrder = { 1, 3, 2, 4 };
    private int currentIndex = 0;

    public GameObject door;

    public void PressButton(int buttonNumber)
    {
        if (buttonNumber == correctOrder[currentIndex])
        {
            currentIndex++;

            if (currentIndex == correctOrder.Length)
            {
                door.SetActive(false);
            }
        }
        else
        {
            currentIndex = 0;
        }
    }
}
