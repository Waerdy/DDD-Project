using UnityEngine;
using TMPro;

public class UIPrompt : MonoBehaviour
{
    private Camera mainCam;
    [SerializeField] private TextMeshProUGUI promptText;
    [SerializeField] private GameObject UI;

    private void Start() //ensures panel is hidden upon start
    {
        mainCam = Camera.main;
        UI.SetActive(false);
    }

    private void LateUpdate()
    {
        var rotate = mainCam.transform.rotation;
        transform.LookAt(transform.position + rotate * Vector3.forward, rotate * Vector3.up); //rotates the canvas to face the camera
    }
    public bool IsActive = false;
    public void SetUp(string promptTextUI) //opens the ui panel when near interactable
    {
        promptText.text = promptTextUI;
        UI.SetActive(true);
        IsActive = true;
    }

    public void Close() //closes the ui panel when not near interactable
    {
        UI.SetActive(false);
        IsActive = false;
    }
}
