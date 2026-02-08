using System.Collections.Generic;
using UnityEngine;

public class trash : MonoBehaviour, IInteractable
{
    public float degreeFromPos { get; set; }
    public bool interacted { get; set; }

    public void Start()
    {
        degreeFromPos = 270;
    }
    public void onInteract()
    {
        interacted = true;
        DialogueSystem dialogue = GameObject.Find("UI").GetComponent<DialogueSystem>();
        dialogue.replics = new List<string>();
        dialogue.replics.Add("It smells bad.");
        dialogue.replics.Add("It rings if I touch it.");
        dialogue.startDialogue();
    }
}
