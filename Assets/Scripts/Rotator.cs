using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 45; // ������ ������

    private void Update()
    {
        // ����� ���� ��� �-Y
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
