using UnityEngine;
using TMPro;

public class DialogueLines : MonoBehaviour
{
    [SerializeField] TMP_Text DialogueText;
    [SerializeField] string[] textLines;

    int currentLine;


    public void NextDialogueLine()
    {
        currentLine++;
        DialogueText.text = textLines[currentLine];
    }

}
