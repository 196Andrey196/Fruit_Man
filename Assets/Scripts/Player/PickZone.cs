
using UnityEngine;

public class PickZone : MonoBehaviour
{
    public GameObject selectObject;
    [SerializeField] private PickPoint _pickPoint;
    [SerializeField] private PlayerAction _plyerAction;
    private void OnTriggerEnter(Collider other)
    {
        if (selectObject == other.gameObject && selectObject.tag == other.gameObject.tag)
        {
            _pickPoint.itemForPickUp = other.gameObject;
            _plyerAction.StartPickUpItem();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == selectObject)
        {
            _pickPoint.itemForPickUp = null;
            selectObject = null;
        }
    }
}
