using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleVisibility : MonoBehaviour
{
    private bool isVisible = true;
    private MeshRenderer meshRenderer;

    private void Start()
    {
        // קבלת רכיב ה-MeshRenderer של הקפסולה
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame) // בדיקת לחיצה על מקש הרווח
        {
            isVisible = !isVisible; // הפיכת מצב הנראות
            meshRenderer.enabled = isVisible; // הפעלה או כיבוי של רכיב ה-MeshRenderer
        }
    }
}
