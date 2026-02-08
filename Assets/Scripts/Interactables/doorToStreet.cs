using System.Collections.Generic;
using UnityEngine;

public class doorToStreet : MonoBehaviour, IInteractable
{
    public float degreeFromPos { get; set; }
    public bool interacted { get; set; }

    public void Start()
    {
        degreeFromPos = 180;
    }
    public void onInteract()
    {
        interacted = true;
        DialogueSystem dialogue = GameObject.Find("UI").GetComponent<DialogueSystem>();
        dialogue.replics = new List<string>();
        dialogue.replics.Add("It leads to the street.");
        dialogue.replics.Add("I didn't open it for a month.");
        dialogue.replics.Add("Money is running out.");
        dialogue.startDialogue();
    }
}
