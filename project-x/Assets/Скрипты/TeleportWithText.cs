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

        // Получаем компоненты Canvas и Text
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

        // Показываем текст
        if (displayText != null)
        {
            displayText.text = teleportText;
            canvas.enabled = true;
        }

        // Ожидаем displayTime
        yield return new WaitForSeconds(displayTime);

        // Скрываем текст
        if (displayText != null)
        {
            canvas.enabled = false;
        }

        // Телепортируем игрока
        playerTransform.position = teleportDestination.position;

        // Воспроизводим звук телепорта
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
