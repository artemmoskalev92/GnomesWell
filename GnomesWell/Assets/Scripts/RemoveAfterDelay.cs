using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������� ������ � �������� ���������.
public class RemoveAfterDelay : MonoBehaviour
{
    // �������� � �������� ����� ���������.
    public float delay = 1.0f;
    void Start()
    {
        // ��������� ����������� 'Remove'.
        StartCoroutine("Remove");
    }
    IEnumerator Remove()
    {
        // ����� 'delay' ������ � ����� ���������� ������ gameObject, �������������� � ������� this.
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
        // ������ ������������ ����� Destroy(this) - �� ��������� ��� ������ �������� RemoveAfterDelay.
    }
}