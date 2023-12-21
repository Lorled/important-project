using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    public Transform teleportDestination; // Указывает на позицию, куда будет телепортирован игрок
    public AudioClip teleportSound; // Звук телепорта

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // Добавляем AudioSource, если его нет
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TeleportPlayer(other.transform);
            PlayTeleportSound();
        }
    }

    private void TeleportPlayer(Transform playerTransform)
    {
        playerTransform.position = teleportDestination.position;
    }

    private void PlayTeleportSound()
    {
        if (teleportSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(teleportSound);
        }
    }
}
