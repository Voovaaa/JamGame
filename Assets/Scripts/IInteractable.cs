using UnityEngine;

public interface IInteractable
{
    public float degreeFromPos { get; set; }
    public void onInteract();
}
