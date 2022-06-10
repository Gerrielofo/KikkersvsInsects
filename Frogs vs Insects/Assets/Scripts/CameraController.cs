using UnityEngine;

public class CameraController : MonoBehaviour
{
    private bool doMovement = true;
    private bool doMouseMovement = true;

    [Header("Zoom")]
    public float scrollSpeed = 5f;
    public float minY = 10f;
    public float maxY = 80f;
    [Header("Look")]
    public float panSpeed = 30f;
    public float panBorderThickness = 10f;
    public float minX = 100f;
    public float maxX = 100f;
    public float minZ = 80f;
    public float maxZ = 80f;

    
    void Update()
    {
        if (GameManager.GameIsOver)
        {
            enabled = false;
            return;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            doMovement = !doMovement;
        
        if (!doMovement)
            return;

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height -panBorderThickness && doMouseMovement == true)
        {
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness && doMouseMovement == true)
        {
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness && doMouseMovement == true)
        {
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness && doMouseMovement == true)
        {
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        Vector3 pos = transform.position;

        pos.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.z = Mathf.Clamp(pos.z, minZ, maxZ);

        transform.position = pos;
    }

    public void ToggleMouseLook()
    {
        doMouseMovement = !doMouseMovement;
        Debug.Log("Mouse Movement Toggled");
    }
}
