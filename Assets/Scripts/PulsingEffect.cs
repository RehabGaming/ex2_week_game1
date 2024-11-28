using UnityEngine;

public class PulsingEffect : MonoBehaviour
{
    public float pulseSpeed = 2; // מהירות הפעימה
    public float scaleAmount = 0.2f; // כמות השינוי בגודל

    private Vector3 originalScale; // גודל התחלתי של הכדור

    private void Start()
    {
        // שמירת הגודל ההתחלתי של הכדור
        originalScale = transform.localScale;
    }

    private void Update()
    {
        // חישוב השינוי בגודל בעזרת פונקציית Sin לתנועה מחזורית
        float scaleChange = Mathf.Sin(Time.time * pulseSpeed) * scaleAmount;
        transform.localScale = originalScale + new Vector3(scaleChange, scaleChange, scaleChange);
    }
}
