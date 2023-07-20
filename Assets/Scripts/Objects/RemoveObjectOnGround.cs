using UnityEngine;

public class RemoveObjectOnGround : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            Destroy(other.gameObject);
        }
    }
}
