using UnityEngine;

public class OpenDoors : MonoBehaviour
{
    private bool isOpen = false;                
    private Quaternion closedRotation;          
    private Quaternion openRotation;            
    private float rotationSpeed = 1.5f;            

    void Start()
    {
        
        closedRotation = transform.rotation;
        openRotation = Quaternion.Euler(0, 90, 0) * closedRotation; 
    }

    private void OnMouseDown()
    {
        Debug.Log("Has hecho click en la puerta");
        isOpen = !isOpen; 
    }

    void Update()
    {
       
        if (isOpen)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, openRotation, Time.deltaTime * rotationSpeed);
        }
        else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, closedRotation, Time.deltaTime * rotationSpeed);
        }
    }
}
