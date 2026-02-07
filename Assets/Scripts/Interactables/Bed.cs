using UnityEditor.SearchService;
using UnityEngine;
using System.Collections.Generic;

public class Bed : MonoBehaviour, IInteractable
{
    public float degreeFromPos { get; set; }

    private void Start()
    {
        degreeFromPos = 270f;
    }
    public void onInteract()
    {
        DialogueSystem dialogue = GameObject.Find("UI").GetComponent<DialogueSystem>();
        dialogue.replics = new List<string>();
        dialogue.replics.Add("qweqwe");
        dialogue.replics.Add("qwe");
        dialogue.startDialogue();
    }
}
