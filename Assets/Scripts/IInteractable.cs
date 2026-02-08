using UnityEngine;

public interface IInteractable
{
    public float degreeFromPos { get; set; }
    public bool interacted { get; set; }
    public void onInteract();
}
