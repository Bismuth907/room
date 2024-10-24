using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GuessTheNumber : MonoBehaviour
{

    public TMP_Text messageText;
    public TMP_InputField numberImput;

    private int randomNumber;
    private void Start()
    {
        //messageText.text = "Hello World!";
        ResetGame();
    }

    public void Try()
    {
        if (string.IsNullOrWhiteSpace(numberImput.text) == true)
        {
            messageText.text = "Please enter a valid number.";
            numberImput.text = "";
            return;
        }

        if (int.TryParse(numberImput.text, out int playerNumber)) ;
        {
            if (playerNumber == randomNumber)
            {
                messageText.text = "VICTORY!!!";
            }
            else if (playerNumber > randomNumber)
            {
                messageText.text = "Lower...";
            }
            else if (playerNumber < randomNumber)
            {
                messageText.text = "Greater...";
            }
            else
            {
                messageText.text = "Please enter a valid number.";
            }

            numberImput.text = "";
        }
    }

    public void ResetGame()
    {
        randomNumber = Random.Range(1, 100 + 1);
        Debug.Log("Generates number: " + randomNumber);
        messageText.text = "Guess the number...";
    }
}
