using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class DialogueSystem : MonoBehaviour
{
    TMP_Text textArea;
    int currentReplicIndex;

    public List<string> replics;
    public float ReplicsDelay;
    private void Start()
    {
        textArea = transform.Find("dialogue text").GetComponent<TMP_Text>();
    }
    public void startDialogue()
    {
        CameraMovement.canMove = false;
        textArea.enabled = true;
        currentReplicIndex = 0;
        iteration();
    }
    public void iteration()
    {
        if (currentReplicIndex >= replics.Count)
        {
            endDialogue();
            return;
        }
        textArea.text = replics[currentReplicIndex];
        currentReplicIndex += 1;
        Invoke("iteration", ReplicsDelay);
    }
    public void endDialogue()
    {
        textArea.enabled = false;
        CameraMovement.canMove = true;
    }
}
