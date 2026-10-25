
using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{
    public Camera playerCamera;
    public float interactionDistance = 3f;

    void Update()
    {
        if (Time.timeScale == 0f)
            return;

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (playerCamera == null)
                return;

            Ray ray = new Ray(
                playerCamera.transform.position,
                playerCamera.transform.forward
            );

            if (Physics.Raycast(ray, out RaycastHit hit, interactionDistance))
            {
                Interactable item =
                    hit.collider.GetComponentInParent<Interactable>();

                if (item != null)
                    item.Interact();
            }
        }
    }
}
