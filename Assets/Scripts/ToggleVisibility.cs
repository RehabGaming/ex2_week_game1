using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleVisibility : MonoBehaviour
{
    private bool isVisible = true;
    private MeshRenderer meshRenderer;

    private void Start()
    {
        // ���� ���� �-MeshRenderer �� �������
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame) // ����� ����� �� ��� �����
        {
            isVisible = !isVisible; // ����� ��� ������
            meshRenderer.enabled = isVisible; // ����� �� ����� �� ���� �-MeshRenderer
        }
    }
}
