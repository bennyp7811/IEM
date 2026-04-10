using UnityEngine;

public class ColePuzzleManager : MonoBehaviour
{
    public int[] correctOrder = { 2, 1, 3, 4 };
    private int currentIndex = 0;
    public GameObject tasks;


    public moveDoors moveDoors;
    public moveDoors moveDoors2;

    public void start()
    {
        tasks.GetComponent<taskscomplete>();
        // moveDoors = GameObject.doorRight.GetComponent<moveDoors>();
    }
        


    public void PressButton(int buttonNumber)
    {
        if (buttonNumber == correctOrder[currentIndex])
        {
            currentIndex++;

            if (currentIndex == correctOrder.Length)
            {
                taskscomplete.tasks++;

                // moveDoors.moveRight();
                // moveDoors2.moveLeft();


            }
        }
        else
        {
            currentIndex = 0;
        }
    }
}
