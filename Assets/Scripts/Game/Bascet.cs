using UnityEngine;
using System.Collections.Generic;

public class Bascet : MonoBehaviour
{
    [SerializeField] private Challenge _challenge;
    [SerializeField] private CollectionIndicator _collectionIndicator;
    [SerializeField] private List<GameObject> _itemList;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item") && !_itemList.Contains(other.gameObject))
        {
            string name = other.gameObject.GetComponent<Item>().name;
            _challenge.UpdateItemCountInBascet(name);
            _collectionIndicator.gameObject.SetActive(true);
            StartCoroutine(_collectionIndicator.FadeAndMove());
            _itemList.Add(other.gameObject);
        }


    }

}
