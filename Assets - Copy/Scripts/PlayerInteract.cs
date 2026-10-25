
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public Camera playerCamera;
    public float interactDistance = 3f;
    public GameObject interactionPrompt;

    private Interactable currentInteractable;

    private void Start()
    {
        if (playerCamera == null)
            playerCamera = Camera.main;

        if (interactionPrompt != null)
            interactionPrompt.SetActive(false);
        else
            Debug.LogError("Interaction Prompt is not assigned!", this);
    }

    private void Update()
    {
        if (Time.timeScale == 0f)
            return;

        currentInteractable = null;

        if (playerCamera != null)
        {
            Ray ray = new Ray(
                playerCamera.transform.position,
                playerCamera.transform.forward
            );

            if (Physics.Raycast(ray, out RaycastHit hit, interactDistance))
            {
                currentInteractable =
                    hit.collider.GetComponentInParent<Interactable>();
            }
        }

        if (interactionPrompt != null)
        {
            interactionPrompt.SetActive(
                currentInteractable != null
            );
        }

        if (currentInteractable != null &&
            Input.GetKeyDown(KeyCode.E))
        {
            currentInteractable.Interact();
        }
    }
}
