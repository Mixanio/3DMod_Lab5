using UnityEngine;

public class InteractAnimToggle : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private float crossFadeTime = 0.12f;
    private bool isOpen;

    private void Awake()
    {
        if (animator == null) animator = GetComponent<Animator>();
    }

    public string Hint => "E Ч открыть/закрыть";
    public void Interact()
    {
        if (animator == null) return;
        isOpen = !isOpen;
        // »м€ стейта включает слой: "Base Layer.Open" / "Base Layer.Closed" :contentReference[oaicite:5]{index=5}

        string stateName = isOpen ? "Base Layer.Open" : "Base Layer.Closed";
        // CrossFade в секундах :contentReference[oaicite:6]{index=6}
        animator.CrossFadeInFixedTime(stateName, crossFadeTime);
    }

}