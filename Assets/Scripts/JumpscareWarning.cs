using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpscareWarning : MonoBehaviour
{
    public GameObject text;   // The trigger zone that initiates the event.
    public int delay;
    public GameObject box;

    private void Start()
    {
        // Initially, the zombie is hidden and not active.
        text.SetActive(false);
    }

    void OnTriggerEnter()
    {
        // Activate the zombie, creating a jump scare.
        text.SetActive(true);

        // Start a coroutine to handle the conclusion of the jump scare.
        StartCoroutine(EndJump());
    }

    IEnumerator EndJump()
    {
        // Wait for 2 seconds, creating a delay in the event.
        yield return new WaitForSeconds(delay);
        box.SetActive(false);
        // Hide the zombie character and deactivate the trigger zone.
        text.SetActive(false);

    }
}