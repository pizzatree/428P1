using UnityEngine;

public class Roars : MonoBehaviour
{
    [SerializeField] private AudioClip roar;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Invoke(nameof(DoTheRoar), 0f);
    }

    private void DoTheRoar()
    {
        var pitch  = Random.Range(0.75f, 1.25f);
        var volume = Random.Range(0.6f,  0.8f);

        audioSource.pitch = pitch;
        audioSource.PlayOneShot(roar, volume);
        
        var nextRoar = Random.Range(0.5f, 4f);
        Invoke(nameof(DoTheRoar), nextRoar);
    }
}