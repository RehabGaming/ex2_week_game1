using UnityEngine;

public class Oscillator : MonoBehaviour
{
    // משתנים לשליטה בתנועה
    public float range = 5; // טווח התנועה
    public float speed = 1; // תדירות התנועה

    private Vector3 startPos; // מיקום התחלתי של האובייקט

    private void Start()
    {
        // שמירת המיקום ההתחלתי של האובייקט
        startPos = transform.position;
    }

    private void Update()
    {
        // חישוב התנועה על פי פונקציית Sin לתנועה מחזורית
        float offset = Mathf.Sin(Time.time * speed) * range;
        transform.position = startPos + new Vector3(offset, 0, 0); // תנועה בציר ה-X
    }
}
