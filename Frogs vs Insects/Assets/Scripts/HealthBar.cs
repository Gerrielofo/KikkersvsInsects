using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Transform insect;
    public Vector3 offSet;
 
    void Update()
    {
        if (insect == null)
        {
            Destroy(gameObject);
            return;
        }
        transform.position = insect.position + offSet;
    }
}
