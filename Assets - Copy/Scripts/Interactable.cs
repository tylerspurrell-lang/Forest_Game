
using UnityEngine;
using System.Collections;

public class Interactable : MonoBehaviour
{
    [Header("Interaction")]
    [TextArea(2, 5)]
    public string description;

    public bool finalChoice;
    public StoryManager storyManager;

    [Header("Clue Settings")]
    public bool isClue;

    [TextArea(3, 8)]
    public string clueText;

    private bool clueCollected = false;

    [Header("Interaction Sound")]
    public AudioSource interactionSound;

    [Header("Radio Background Static")]
    public AudioSource backgroundStatic;
    public bool stopStaticOnInteract;

    private Coroutine radioRoutine;

    public void Interact()
    {
        if (storyManager == null)
        {
            storyManager = FindFirstObjectByType<StoryManager>();
        }

        if (storyManager == null)
        {
            Debug.LogError(
                "Interactable: StoryManager not found.", this);
            return;
        }

        // RADIO: play the radio sound sequence.
        if (stopStaticOnInteract &&
            backgroundStatic != null &&
            interactionSound != null)
        {
            if (radioRoutine != null)
            {
                StopCoroutine(radioRoutine);
            }

            radioRoutine = StartCoroutine(PlayRadioSequence());
        }
        else if (interactionSound != null)
        {
            interactionSound.Play();
        }

        // RADIO: continue the main story.
        if (stopStaticOnInteract)
        {
            storyManager.InteractRadio();
        }
        // FINAL CHOICE: show the ending options.
        else if (finalChoice)
        {
            storyManager.ShowChoices();
        }
        // CLUE: count this clue only once.
        else if (isClue)
        {
            if (!clueCollected)
            {
                clueCollected = true;

                storyManager.RegisterClue(clueText);
            }
            else
            {
                storyManager.ShowMessage(
                    "CLUE ALREADY FOUND\n\n" +
                    clueText
                );
            }
        }
        // ORDINARY OBJECT: show its description.
        else
        {
            storyManager.ShowMessage(description);
        }
    }

    private IEnumerator PlayRadioSequence()
    {
        backgroundStatic.Stop();
        interactionSound.Stop();
        interactionSound.Play();

        yield return new WaitWhile(
            () => interactionSound != null &&
                  interactionSound.isPlaying
        );

        if (backgroundStatic != null)
        {
            backgroundStatic.Play();
        }

        radioRoutine = null;
    }
}
