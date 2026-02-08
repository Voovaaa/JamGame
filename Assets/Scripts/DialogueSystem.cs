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
        replics = new List<string>();
        replics.Add("hi");
        replics.Add("hi2");
        textArea = transform.Find("dialogue text").GetComponent<TMP_Text>();
        CameraMovement.canMove = false;
        startDialogue();

    }
    public void startDialogue()
    {
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
