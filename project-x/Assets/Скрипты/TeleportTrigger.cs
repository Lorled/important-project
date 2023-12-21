using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    public Transform teleportDestination; // ��������� �� �������, ���� ����� �������������� �����
    public AudioClip teleportSound; // ���� ���������

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // ��������� AudioSource, ���� ��� ���
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
