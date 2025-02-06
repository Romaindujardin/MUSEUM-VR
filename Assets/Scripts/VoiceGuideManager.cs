using UnityEngine;

public class VoiceGuideManager : MonoBehaviour
{
    public AudioSource audioSource;  // L'AudioSource pour jouer l'instruction
    public AudioClip voixDEntree; // Fichier audio nomm� "voix d'entr�e"
    public float startDelay = 2f; // D�lai avant de jouer l'audio

    void Start()
    {
        if (voixDEntree != null)
        {
            // Lancer l'instruction apr�s un d�lai
            Invoke(nameof(PlayInstruction), startDelay);
        }
        else
        {
            Debug.LogWarning("Aucun fichier audio 'voix d'entr�e' assign� !");
        }
    }

    void PlayInstruction()
    {
        audioSource.clip = voixDEntree;
        audioSource.Play();
        Debug.Log("Lecture de la voix d'entr�e.");
    }
}
