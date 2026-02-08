using System.Collections.Generic;
using UnityEngine;

public class bottleOnFloor : MonoBehaviour, IInteractable
{
    public float degreeFromPos { get; set; }
    public bool interacted { get; set; }

    public void Start()
    {
        degreeFromPos = 90;
    }
    public void onInteract()
    {
        interacted = true;
        DialogueSystem dialogue = GameObject.Find("UI").GetComponent<DialogueSystem>();
        dialogue.replics = new List<string>();
        dialogue.replics.Add("It doesn't taste good.");
        dialogue.replics.Add("It gets better after i drink.");
        dialogue.replics.Add("It's almost empty. I've got more in kitchen.");
        dialogue.startDialogue();
    }
}
