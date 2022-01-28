using UnityEngine.Events;
using UnityEngine;


// �������� UnityEvent, ����� ������ � ����� "Player" �������� ������� �������.
[RequireComponent(typeof(Collider2D))]
public class SignalOfTouch : MonoBehaviour
{
    // UnityEvent ��� ���������� � ����� �� �������.
    // ���������� ����� ������������ � ���������.
    public UnityEvent onTouch;
    // ���� ������� �������� true, ��� ������� ������������� ���� �� AudioSource.
    public bool playAudioOnTouch = true;
    // ����� �������������� ���� � ������� �������� ��������, ���������� SendSignal.
    void OnTriggerEnter2D(Collider2D collider)
    {
        SendSignal(collider.gameObject);
    }

// ����� �������������� ������� � ������ ��������, ���������� SendSignal.
void OnCollisionEnter2D(Collision2D collision)
    {
        SendSignal(collision.gameObject);
    }
    // ��������� ������� ���� "Player" � ������� ������� � �������� UnityEvent, ���� ����� ��� �������.
    void SendSignal(GameObject objectThatHit)
    {
        // ������ ������� ����� "Player"?
        if (objectThatHit.CompareTag("Player"))
        {
            // ���� ��������� ������������� ����, ���������� ������� ���
            if (playAudioOnTouch)
            {
                var audio = GetComponent<AudioSource>();
                // ���� ������� �������������� � �������� ����� ���������� �������, ������������� ����
                if (audio && audio.gameObject.activeInHierarchy)
                    audio.Play();
            }
            // ������� �������
            onTouch.Invoke();
        }
    }
}