using UnityEngine;

public class Oscillator : MonoBehaviour
{
    // ������ ������ ������
    public float range = 5; // ���� ������
    public float speed = 1; // ������ ������

    private Vector3 startPos; // ����� ������ �� ��������

    private void Start()
    {
        // ����� ������ ������� �� ��������
        startPos = transform.position;
    }

    private void Update()
    {
        // ����� ������ �� �� �������� Sin ������ �������
        float offset = Mathf.Sin(Time.time * speed) * range;
        transform.position = startPos + new Vector3(offset, 0, 0); // ����� ���� �-X
    }
}
