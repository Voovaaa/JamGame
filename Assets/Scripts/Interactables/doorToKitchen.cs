using System.Collections.Generic;
using UnityEngine;

public class doorToKitchen : MonoBehaviour, IInteractable
{
    public float degreeFromPos { get; set; }
    public bool interacted { get; set; }

    public void Start()
    {
        degreeFromPos = 0;
    }
    public void onInteract()
    {
        interacted = true;
        DialogueSystem dialogue = GameObject.Find("UI").GetComponent<DialogueSystem>();
        dialogue.replics = new List<string>();
        dialogue.replics.Add("It leads to the kitchen.");
        dialogue.replics.Add("I don't want to leave my room.");
        dialogue.startDialogue();
    }
}
