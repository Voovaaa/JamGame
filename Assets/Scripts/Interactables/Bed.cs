using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Bed : MonoBehaviour, IInteractable
{
    public float degreeFromPos { get; set; }
    public bool interacted { get; set; }

    private void Start()
    {
        degreeFromPos = 270f;
    }
    public void onInteract()
    {
        if (InteractedChecker.allInteracted)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            return;
        }
        interacted = true;
        DialogueSystem dialogue = GameObject.Find("UI").GetComponent<DialogueSystem>();
        dialogue.replics = new List<string>();
        dialogue.replics.Add("Here i am lying.");
        dialogue.replics.Add("I like sleeping.");
        dialogue.startDialogue();
    }
}
