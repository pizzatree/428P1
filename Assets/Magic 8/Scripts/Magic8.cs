using System.Linq;
using TMPro;
using UnityEngine;

namespace Magic_8.Scripts
{
    public class Magic8 : MonoBehaviour
    {
        [Header("Tweakables")] 
        [SerializeField] private float rotThreshold = 0.65f;
        
        [Header("Dependencies")]
        [SerializeField] private Magic8Sayings magic8Sayings;
        [SerializeField] private AudioClip     newSayingSound;

        private TMP_Text    sayingText;
        private AudioSource audioSource;

        private int      faceCheckDirection;
        private string[] sayings;

        private void Start()
        {
            if(!ResourcesArePresent())
                Destroy(this);

            faceCheckDirection = -1;
            
            sayings = magic8Sayings.Positive
                                   .Concat(magic8Sayings.Neutral)
                                   .Concat(magic8Sayings.Negative)
                                   .ToArray();

            audioSource = gameObject.AddComponent<AudioSource>();
            sayingText  = GetComponentInChildren<TMP_Text>();

            UpdateSaying();
        }

        private void Update()
        {
            if(transform.up.y * faceCheckDirection < rotThreshold)
                return;

            faceCheckDirection *= -1;

            if(faceCheckDirection != -1)
                return;
            
            UpdateSaying();
            PlaySound();
        }

        private void UpdateSaying()
        {
            int i = Random.Range(0, sayings.Length);
            sayingText.text = sayings[i];
        }

        private void PlaySound()
        {
            audioSource.volume = Random.Range(0.6f, 0.7f);
            audioSource.pitch  = Random.Range(0.6f, 1.4f);
            audioSource.PlayOneShot(newSayingSound);
        }

        private bool ResourcesArePresent()
        {
            if(!magic8Sayings)
            {
                Debug.LogWarning($"{name} does not have a valid Magic 8 Sayings!");
                return false;
            }

            if(!newSayingSound)
            {
                Debug.LogWarning($"{name} does not have a valid sound!");
                return false;
            }

            return true;
        }
    }
}