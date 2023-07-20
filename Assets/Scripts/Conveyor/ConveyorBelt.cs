using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    [SerializeField] private float _speed, _conveyorSpeed;
    [SerializeField] private Vector3 _direction;
    [SerializeField] private List<GameObject> _onBelt;
    private Material material;
    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }
    private void Update()
    {
        AnimatedConveyor();
    }
    void FixedUpdate()
    {
        MoveObjects();
    }
    private void AnimatedConveyor()
    {
        material.mainTextureOffset += new Vector2(0, 1) * _conveyorSpeed * Time.deltaTime;
    }
    private void MoveObjects()
    {
        for (int i = 0; i <= _onBelt.Count - 1; i++)
        {
            if (_onBelt[i] == null)
            {
                 _onBelt.Remove(_onBelt[i]);
            }
            else
            {
                Rigidbody objectOnBelt = _onBelt[i].GetComponent<Rigidbody>();
                objectOnBelt.MovePosition(objectOnBelt.transform.position + _direction * _speed * Time.fixedDeltaTime);
            }
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject != null)
            _onBelt.Add(collision.gameObject);
    }

    private void OnCollisionExit(Collision collision)
    {
        _onBelt.Remove(collision.gameObject);
    }
    public void RemoveInList(GameObject gameObjectOut)
    {
        _onBelt.Remove(gameObjectOut);
    }
}