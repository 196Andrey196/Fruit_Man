using UnityEngine;
using System.Collections;

public class FinalLevelAction : MonoBehaviour
{
    [SerializeField] private Camera _mainCamera;
    [SerializeField] private GameObject _winMenu;
    public float moveDistance = 2f;
    public float moveSpeed = 1f;

    private Vector3 targetPosition;
    private Vector3 initialPosition;
    private float totalDistance;
    private float currentDistance = 0f;

    private void Start()
    {
        initialPosition = _mainCamera.transform.position;
        targetPosition = initialPosition + _mainCamera.transform.forward * moveDistance;
        totalDistance = Vector3.Distance(initialPosition, targetPosition);
    }

    public IEnumerator FinalAction()
    {
        currentDistance += moveSpeed * Time.deltaTime;

        if (currentDistance < totalDistance)
        {
            float stopPoint = currentDistance / totalDistance;
            _mainCamera.transform.position = Vector3.Lerp(initialPosition, targetPosition, stopPoint);
        }
        else
        {
            _mainCamera.transform.position = targetPosition;
        }
        yield return new WaitForSeconds(1);

        GameObject[] conveyors = GameObject.FindGameObjectsWithTag("Conveyor");
        foreach (GameObject conveyor in conveyors)
        {
            Destroy(conveyor);
        }
        yield return new WaitForSeconds(1);
        _winMenu.SetActive(true);
    }
}
