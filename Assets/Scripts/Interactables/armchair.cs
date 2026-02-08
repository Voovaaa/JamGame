using System.Collections.Generic;
using UnityEngine;

public class armchair : MonoBehaviour, IInteractable
{
    public float degreeFromPos { get; set; }
    public bool interacted { get; set; }

    private void Start()
    {
        degreeFromPos = 180;
    }

    public void onInteract()
    {
        interacted = true;
        DialogueSystem dialogue = GameObject.Find("UI").GetComponent<DialogueSystem>();
        dialogue.replics = new List<string>();
        dialogue.replics.Add("Here i am sitting when im tired of lying.");
        dialogue.replics.Add("I don't like the view, but it's better than sitting on floor.");
        dialogue.startDialogue();
    }
}
