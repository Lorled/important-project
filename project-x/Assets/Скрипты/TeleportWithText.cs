using UnityEngine;
using UnityEngine.UI;

public class TeleportWithText : MonoBehaviour
{
    public Transform teleportDestination;
    public AudioClip teleportSound;
    public string teleportText = "You've been teleported!";
    public float displayTime = 2f;

    private AudioSource audioSource;
    private Text displayText;
    private Canvas canvas;
    private bool isTeleporting = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // �������� ���������� Canvas � Text
        canvas = GetComponentInChildren<Canvas>();
        if (canvas != null)
        {
            displayText = canvas.GetComponentInChildren<Text>();
            canvas.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isTeleporting && other.CompareTag("Player"))
        {
            StartCoroutine(TeleportPlayer(other.transform));
        }
    }

    private System.Collections.IEnumerator TeleportPlayer(Transform playerTransform)
    {
        isTeleporting = true;

        // ���������� �����
        if (displayText != null)
        {
            displayText.text = teleportText;
            canvas.enabled = true;
        }

        // ������� displayTime
        yield return new WaitForSeconds(displayTime);

        // �������� �����
        if (displayText != null)
        {
            canvas.enabled = false;
        }

        // ������������� ������
        playerTransform.position = teleportDestination.position;

        // ������������� ���� ���������
        PlayTeleportSound();

        isTeleporting = false;
    }

    private void PlayTeleportSound()
    {
        if (teleportSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(teleportSound);
        }
    }
}
