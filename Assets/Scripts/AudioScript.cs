using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioClip Homer;
    public AudioClip DonutHomer;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.volume = 1f;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            if (Homer != null)
            {
                audioSource.clip = Homer;
                audioSource.Play();
            }

            if (DonutHomer != null)
            {
                audioSource.clip = DonutHomer;
                audioSource.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (audioSource.isPlaying)
            {
                audioSource.Pause();
            }
        }
    }
}