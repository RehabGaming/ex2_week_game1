using UnityEngine;

public class PulsingEffect : MonoBehaviour
{
    public float pulseSpeed = 2; // ������ ������
    public float scaleAmount = 0.2f; // ���� ������ �����

    private Vector3 originalScale; // ���� ������ �� �����

    private void Start()
    {
        // ����� ����� ������� �� �����
        originalScale = transform.localScale;
    }

    private void Update()
    {
        // ����� ������ ����� ����� �������� Sin ������ �������
        float scaleChange = Mathf.Sin(Time.time * pulseSpeed) * scaleAmount;
        transform.localScale = originalScale + new Vector3(scaleChange, scaleChange, scaleChange);
    }
}
