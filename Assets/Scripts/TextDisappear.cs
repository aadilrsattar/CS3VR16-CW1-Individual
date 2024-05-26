using UnityEngine;
using UnityEngine.UI;

public class TextDisappear : MonoBehaviour
{
    public float delay = 4.0f;  // Delay in seconds before text disappears
    public AudioSource sound;
    public GameObject intText;
    private float timer;

    private void Start()
    {
        sound.Play();
        timer = 0;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delay)
        {
            // If the timer exceeds the specified delay, destroy the text object
            intText.SetActive(false);

        }
    }
}
