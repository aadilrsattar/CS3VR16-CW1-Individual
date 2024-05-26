// This script is designed for a Unity game. It's used to create a jump scare event
// when the player enters a specific trigger zone.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    public AudioSource Scream;      // The sound of a scream when the event triggers.
    public GameObject Zombie;       // A reference to the zombie character.
    public GameObject TriggerBox;   // The trigger zone that initiates the event.
    public int delay;

    private void Start()
    {
        // Initially, the zombie is hidden and not active.
        Zombie.SetActive(false);
    }

    void OnTriggerEnter()
    {
        // When the player enters the trigger zone, play the scream sound.
        Scream.Play();

        // Activate the zombie, creating a jump scare.
        Zombie.SetActive(true);

        // Start a coroutine to handle the conclusion of the jump scare.
        StartCoroutine(EndJump());
    }

    IEnumerator EndJump()
    {
        // Wait for 2 seconds, creating a delay in the event.
        yield return new WaitForSeconds(delay);

        // Hide the zombie character and deactivate the trigger zone.
        Zombie.SetActive(false);
        TriggerBox.SetActive(false);
    }
}