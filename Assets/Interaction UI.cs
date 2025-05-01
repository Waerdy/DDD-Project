using UnityEngine;

public interface InteractionUI
{
    public string InteractionPrompt { get; }
    public bool Interact(Interactor interactor);
}
