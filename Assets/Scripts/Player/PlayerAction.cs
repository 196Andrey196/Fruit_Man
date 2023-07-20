using UnityEngine;

public class PlayerAction : MonoBehaviour
{

    [SerializeField] private Transform _pickUpPoitn;
    [SerializeField] private GameObject _pickedItem;
    public GameObject pickedItem
    {
        set { _pickedItem = value; }
        get { return _pickedItem; }
    }
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void StartPickUpItem()
    {
        animator.SetTrigger("PickUp");
    }

    private void DropItem()
    {
        if (_pickedItem)
        {
            Rigidbody curentItem = _pickedItem.GetComponent<Rigidbody>();
            curentItem.isKinematic = false;
            curentItem.transform.parent = null;
            _pickedItem = null;
        }

    }






}

