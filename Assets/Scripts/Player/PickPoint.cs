using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickPoint : MonoBehaviour
{
    [SerializeField] private PlayerAction _palyerAction;
    public GameObject itemForPickUp;
    private void OnTriggerEnter(Collider other)
    {
        if (itemForPickUp == other.gameObject && itemForPickUp != null)
        {
            _palyerAction.pickedItem = other.gameObject;
            Rigidbody curentItem = other.gameObject.GetComponent<Rigidbody>();
            curentItem.isKinematic = true;
            curentItem.transform.parent = transform;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (itemForPickUp == other.gameObject)
            itemForPickUp = null;
    }
}
