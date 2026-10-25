
using UnityEngine;

public class StoryInteractable : MonoBehaviour
{
    public enum InteractableType
    {
        Radio,
        Clue
    }

    [Header("Interactable Settings")]
    public InteractableType interactableType;

    [TextArea(3, 6)]
    public string clueText = "You found a research record.";

    public StoryManager storyManager;

    private bool playerInRange;
    private bool alreadyUsed;

    void Start()
    {
        if (storyManager == null)
            storyManager = FindFirstObjectByType<StoryManager>();
    }

    void Update()
    {
        if (Time.timeScale == 0f || !playerInRange || alreadyUsed)
            return;

        if (!Input.GetKeyDown(KeyCode.E))
            return;

        if (storyManager == null)
        {
            Debug.LogError("StoryInteractable: No StoryManager found.", this);
            return;
        }

        if (interactableType == InteractableType.Radio)
        {
            storyManager.InteractRadio();
        }
        else
        {
            alreadyUsed = true;
            storyManager.RegisterClue(clueText);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            playerInRange = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            playerInRange = false;
    }
}
