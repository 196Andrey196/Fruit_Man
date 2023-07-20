using UnityEngine;

public class RemoveObjectOutCamera : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
