using UnityEngine;

public class PixelPerfectCameraSnap : MonoBehaviour
{
    void LateUpdate()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Round(pos.x * 100f) / 100f;
        pos.y = Mathf.Round(pos.y * 100f) / 100f;
        transform.position = pos;
    }
}