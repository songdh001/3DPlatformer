using UnityEngine;

public class DoorInteract : MonoBehaviour
{
    public Transform doorPivot;
    public Transform doorTransform; // ½ÇÁ¦ ¹®
    public GameObject promptUI;     // "Press E to Open" UI
    public float openAngle = 90f;
    public float openSpeed = 2f;

    private bool isPlayerNear = false;
    private bool isOpen = false;

    void Update()
    {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
            isOpen = !isOpen;
        }

        if (isOpen)
        {
            Quaternion targetRotation = Quaternion.Euler(0f, openAngle, 0f);
            doorPivot.rotation = Quaternion.Slerp(doorPivot.rotation, targetRotation, Time.deltaTime * openSpeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;
            if (promptUI != null)
                promptUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
            if (promptUI != null)
                promptUI.SetActive(false);
        }
    }
}
