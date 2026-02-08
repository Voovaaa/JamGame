using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class Interact : MonoBehaviour
{
    public InputActionAsset inputActions;
    List<GameObject> interactables;

    // Update is called once per frame
    void Update()
    {
        if (inputActions.FindAction("Interact").WasPressedThisFrame() && CameraMovement.canMove)
        {
            interactables = GetComponent<CameraMovement>().currentPosition.GetComponent<Position>().interactables;
            if (interactables == null) return;
            foreach (GameObject interactable in interactables)
            {
                if (interactable.GetComponent<IInteractable>().degreeFromPos == transform.eulerAngles.y)
                {
                    interactable.GetComponent<IInteractable>().onInteract();
                    return;
                }
            }
        }
    }
}
