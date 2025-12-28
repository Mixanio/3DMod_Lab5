using UnityEngine;

public class SimpleRayInteractor : MonoBehaviour
{
    [SerializeField] private float maxDistance = 3f;

    private InteractAnimToggle current;

    private void Update()
    {
        // Raycast: луч по всем коллайдерам сцены :contentReference[oaicite:7]{index=7}
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, maxDistance))
        {
            current = hit.collider.GetComponentInParent<InteractAnimToggle>();

            // Нажатие E через GetKeyDown + KeyCode.E :contentReference[oaicite:8]{index=8}
            if (current != null && Input.GetKeyDown(KeyCode.E))
                current.Interact();
        }
        else
        {
            current = null;
        }

    }

    private void OnGUI()
    {
        if (current == null) return;
        GUI.Label(new Rect(20, 20, 250, 30), current.Hint);
    }

}