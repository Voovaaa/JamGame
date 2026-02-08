using System.Collections.Generic;
using UnityEngine;

public class bottleOnNightstand : MonoBehaviour, IInteractable
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
        dialogue.replics.Add("It's empty. :(");
        dialogue.startDialogue();
    }
}
