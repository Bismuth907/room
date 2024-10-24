using UnityEngine;
using TMPro;
public class DialoguePlayer : MonoBehaviour
{

    public Dialogueasset dialogueasset;
    public TMP_Text dialogueText;
    public GameObject dialogueBox;
    private int dialogueLineIndex;
    
    private void Start()
    {
        dialogueText.text = dialogueasset.Dialogue[0];
    }




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            dialogueLineIndex += 1;

            if (dialogueLineIndex < dialogueasset.Dialogue.Length)
            {
                dialogueText.text = dialogueasset.Dialogue[dialogueLineIndex];
            }
            else
            {
                dialogueBox.gameObject.SetActive(false);
            }
        }
    }

}
