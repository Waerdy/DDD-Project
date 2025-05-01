using UnityEngine;

public class Sign : MonoBehaviour, InteractionUI
{
    [SerializeField] private string prompt;

    public string InteractionPrompt => prompt;
    public bool Interact(Interactor interactor) //debug log is for testing
    {
        Debug.Log("Sign read");
        return true;
    }
}

