using UnityEngine;

public class Sign : MonoBehaviour, InteractionUI
{
    [SerializeField] private string prompt;
    [SerializeField] private GameObject SignUI;

    private void Start() //ensures sign UI is hidden upon start
    {
        SignUI.SetActive(false);
    }

    public string InteractionPrompt => prompt;
    public bool Interact(Interactor interactor) //debug log is for testing
    {
        Debug.Log("Sign read");
        SignUI.SetActive(true);
        return true;
    }
}

