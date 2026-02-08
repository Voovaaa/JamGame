using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class InteractedChecker : MonoBehaviour
{
    public static bool allInteracted;
    public List<GameObject> interactables;

    private void Update()
    {
        foreach (GameObject interactable in interactables)
        {
            if (!interactable.GetComponent<IInteractable>().interacted)
            {
                return;
            }
        }
        allInteracted = true;
    }
}
