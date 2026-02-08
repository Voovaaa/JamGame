using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interact : MonoBehaviour
{
    public InputActionAsset inputActions;
    List<GameObject> interactables;
    public bool canInteract;
    bool endDialogueStarted;

    // Update is called once per frame
    void Update()
    {
        canInteract = !InteractedChecker.allInteracted;
        if (!canInteract && !endDialogueStarted)
        {
            Invoke("startEndDialogue", 10);
        }
        if (inputActions.FindAction("Interact").WasPressedThisFrame() && CameraMovement.canMove)
        {
            interactables = GetComponent<CameraMovement>().currentPosition.GetComponent<Position>().interactables;
            if (interactables == null) return;
            foreach (GameObject interactable in interactables)
            {
                if (interactable.GetComponent<IInteractable>().degreeFromPos == transform.eulerAngles.y)
                {
                    if (canInteract)
                    {
                        interactable.GetComponent<IInteractable>().onInteract();
                        return;
                    }
                    else if (interactable.name == "Bed" && endDialogueStarted)
                    {
                        interactable.GetComponent<IInteractable>().onInteract();
                        return;
                    }
                }
            }
        }
    }
    public void startEndDialogue()
    {
        endDialogueStarted = true;
        DialogueSystem dialogue = GameObject.Find("UI").GetComponent<DialogueSystem>();
        dialogue.replics = new List<string>();
        dialogue.replics.Add("I want to sleep");
        dialogue.startDialogue();
    }
}
