using UnityEngine;

public abstract class Changer : MonoBehaviour
{
    [SerializeField] protected Vector3 ChangeValue;
    [SerializeField] protected float Duration;

    private void Start()
    {
        Change();
    }

    protected abstract void Change();
}
