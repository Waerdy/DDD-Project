using UnityEngine;
using UnityEngine.InputSystem;

public class Interactor : MonoBehaviour
{
    [SerializeField] private Transform _interactionPoint;
    [SerializeField] private float _interactionPointRad = 2.5f; //area of interaction
    [SerializeField] private LayerMask _interactableMask;
    [SerializeField] private UIPrompt uiPrompt;

    private readonly Collider[] _colliders = new Collider[3];
    [SerializeField] private int _numFound;

    private InteractionUI interactable;

    // Update is called once per frame
    void Update() //checks if area has interactable and allows interaction
    {
        _numFound = Physics.OverlapSphereNonAlloc(_interactionPoint.position, _interactionPointRad, _colliders, _interactableMask);

        if (_numFound > 0)
        {
            interactable = _colliders[0].GetComponent<InteractionUI>();
            if (interactable != null)
            {
                if (!uiPrompt.IsActive) uiPrompt.SetUp(interactable.InteractionPrompt);

                if (Keyboard.current.eKey.wasPressedThisFrame) interactable.Interact(this);
            }
        }
        else
        {
            if (interactable != null) interactable = null;
            if (uiPrompt.IsActive) uiPrompt.Close();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(_interactionPoint.position, _interactionPointRad);
    }
}
