using UnityEngine;

public class WorldToScreen : MonoBehaviour
{
    void Update()
    {
        // Chuyển đổi vị trí của vật thể (transform.position) từ World Space sang Screen Space
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        
        // In tọa độ ra Console để xem
        Debug.Log("Screen Position: " + screenPos);
    }
}