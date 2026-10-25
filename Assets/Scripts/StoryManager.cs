
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StoryManager : MonoBehaviour
{
    [Header("Story UI")]
    public GameObject messagePanel;
    public TMP_Text messageText;
    public GameObject choicesPanel;
    public TMP_Text clueCounterText;

    [Header("Message Buttons")]
    public GameObject continueButton;
    public GameObject backButton;
    public GameObject restartButton;

    [Header("Clue Settings")]
    public int cluesRequired = 3;
    public int cluesFound = 0;

    [Header("Player")]
    public PlayerMovement playerMovement;

    private bool gameEnded = false;
    private bool finalMessageShown = false;
    private bool choicesUnlocked = false;

    private void Awake()
    {
        Time.timeScale = 1f;
    }

    private void Start()
    {
        if (playerMovement == null)
            playerMovement = FindFirstObjectByType<PlayerMovement>();

        if (choicesPanel != null)
            choicesPanel.SetActive(false);

        UpdateClueCounter();

        ShowMessage(
            " Welcome To Forrest Horror Adventure\n\n" +
            "You have arrived at an isolated radio research station " +
            "after receiving a strange distress signal.\n\n" +
            "The station appears abandoned. The radio equipment is " +
            "still powered, but nobody is answering your calls.\n\n" +
            "Search the area for clues. Discover what happened to " +
            "the research team, then return to the radio.\n\n" + "Controls: WASD To Move: Mouse To look around: E To interact with objects:"
        );
    }

    private void SetMessageButtons(
        bool showContinue,
        bool showBack,
        bool showRestart)
    {
        if (continueButton != null)
            continueButton.SetActive(showContinue);

        if (backButton != null)
            backButton.SetActive(showBack);

        if (restartButton != null)
            restartButton.SetActive(showRestart);
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;

        if (playerMovement != null)
            playerMovement.UnlockCursor();
        else
            Cursor.lockState = CursorLockMode.None;

        Cursor.visible = true;
    }

    public void ContinueGame()
    {
        if (gameEnded)
            return;

        if (choicesUnlocked)
        {
            ShowChoices();
            return;
        }

        if (messagePanel != null)
            messagePanel.SetActive(false);

        SetMessageButtons(false, false, false);

        Time.timeScale = 1f;

        if (playerMovement != null)
        {
            playerMovement.enabled = true;
            playerMovement.LockCursor();
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void ShowMessage(string message)
    {
        if (messageText != null)
            messageText.text = message;

        if (messagePanel != null)
            messagePanel.SetActive(true);

        if (choicesPanel != null)
            choicesPanel.SetActive(false);

        // Normal messages show Continue only.
        SetMessageButtons(true, false, false);

        PauseGame();
    }

    public void RegisterClue(string clue)
    {
        if (gameEnded)
            return;

        cluesFound = Mathf.Min(
            cluesFound + 1,
            cluesRequired
        );

        UpdateClueCounter();

        if (cluesFound >= cluesRequired)
        {
            ShowMessage(
                "FINAL CLUE RECOVERED\n\n" +
                clue +
                "\n\nAll three clues have been found. " +
                "Return to the main radio to discover the truth."
            );
        }
        else
        {
            ShowMessage(
                "CLUE RECOVERED\n\n" +
                clue +
                "\n\nFind the remaining clues."
            );
        }
    }

    private void UpdateClueCounter()
    {
        if (clueCounterText != null)
        {
            clueCounterText.text =
                "Clues: " + cluesFound + "/" + cluesRequired;
        }
    }

    public void InteractRadio()
    {
        if (gameEnded)
            return;

        if (cluesFound < cluesRequired)
        {
            ShowMessage(
                "RESEARCH RECORD\n\n" +
                "The station's records describe experiments involving " +
                "an unknown signal that can imitate human voices.\n\n" +
                "The researchers attempted to shut down the tower, " +
                "but the signal continued through the station's receivers.\n\n" +
                "Find all three clues to discover what happened.\n\n" +
                "Clues found: " +
                cluesFound + "/" + cluesRequired
            );

            return;
        }

        if (!finalMessageShown)
        {
            finalMessageShown = true;
            choicesUnlocked = true;

            ShowMessage(
                "FINAL TRANSMISSION\n\n" +
                "You have found the research team's final records.\n\n" +
                "The tower was shut down, but the signal never stopped. " +
                "It learned to travel through the station's receivers, " +
                "imitating the voices of the missing researchers.\n\n" +
                "You reach for the main radio to investigate.\n\n" +
                "The moment you activate it, the static cuts out.\n\n" +
                "A voice comes through. It sounds exactly like you.\n\n" +
                "\"I wondered when you'd arrive.\"\n\n" +
                "You never transmitted your name. You never told the " +
                "station who you were.\n\n" +
                "\"The tower was never the source. It was only the door.\"\n\n" +
                "\"Now that you've opened it, what are you going to do?\"\n\n" +
                "You have three choices."
            );

            return;
        }

        ShowChoices();
    }

    public void ShowChoices()
    {
        if (gameEnded || cluesFound < cluesRequired)
            return;

        choicesUnlocked = false;

        if (messagePanel != null)
            messagePanel.SetActive(false);

        SetMessageButtons(false, false, false);

        if (choicesPanel != null)
            choicesPanel.SetActive(true);

        PauseGame();
    }

    public void ChooseSignal()
    {
        ShowEnding(
            "ENDING 1: THE SIGNAL\n\n" +
            "You decide to respond to the signal, hoping to learn " +
            "what it really is.\n\n" +
            "The radio fills with static. You transmit a short message.\n\n" +
            "For a moment, nothing happens.\n\n" +
            "Then your own voice answers from the speaker:\n\n" +
            "\"Thank you. I needed you to answer.\"\n\n" +
            "The station falls silent. Far away, another radio " +
            "begins to ring.\n\n" +
            "The signal has found a new way out.\n" + "You Lose"
        );
    }

    public void ChooseRescue()
    {
        ShowEnding(
            "ENDING 2: THE SURVIVOR\n" +
            "You choose to search for the missing researcher " +
            "instead of answering the signal.\n" +
            "Following the final coordinates, you find a survivor " +
            "near the station grounds. They look exhausted, but alive.\n" +
            "You lead them away from the tower.\n" +
            "Neither of you speaks until your radio crackles.\n" +
            "A voice comes through. It belongs to the survivor " +
            "standing beside you.\n" +
            "The survivor looks at you and whispers:\n" +
            "\"Don't answer it.\"\n" + "You decide not to answer it and run out of the forest\n" + "You Escaped With The Suvivor\n" + "You Win"
            
        );
    }

    public void ChooseDestroy()
    {
        ShowEnding(
            "ENDING 3: SILENCE\n" +
            "You decide the signal must never be answered.\n" +
            "You destroy the main radio and cut the remaining " +
            "power to the station.\n" +
            "The static stops.\n" +
            "For the first time since arriving, you hear nothing " +
            "but the wind.\n" +
            "You leave believing the nightmare is over.\n" +
            "As you reach the road, your phone rings.\n" +
            "The caller ID displays your own number.\n" +
            "You answer.\n" +
            "\"You didn't think the radio was the only way, did you?\"\n" +
            "The call disconnects.\nYou Lose."
        );
    }

    private void ShowEnding(string ending)
    {
        if (gameEnded)
            return;

        if (choicesPanel != null)
            choicesPanel.SetActive(false);

        if (messagePanel != null)
            messagePanel.SetActive(true);

        if (messageText != null)
            messageText.text = ending;

        // When any ending is selected:
        // Continue hides; Back and Restart appear.
        SetMessageButtons(false, true, true);

        PauseGame();
    }

    public void BackToChoices()
    {
        if (gameEnded)
            return;

        ShowChoices();
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }
}
