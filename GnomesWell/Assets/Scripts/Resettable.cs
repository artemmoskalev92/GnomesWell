using UnityEngine.Events;
using UnityEngine;

// �������� ���� UnityEvent, ������� ������������ ��� ��������� ������� this � �������� ���������.

public class Resettable : MonoBehaviour
{
    // � ��������� ���������� ��� ������� � �������, ������� ������ ���������� � ������ ������ ����.
    public UnityEvent onReset;

    // ���������� ����������� ���� GameManager � ������ ������ ����.
    public void Reset()
    {
      // �������� �������, ������� ������� ��� ������������ ������.
      onReset.Invoke();
    }
}
