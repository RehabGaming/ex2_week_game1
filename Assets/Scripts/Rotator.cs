using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 45; // מהירות הסיבוב

    private void Update()
    {
        // סיבוב סביב ציר ה-Y
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
