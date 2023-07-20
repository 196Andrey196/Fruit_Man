
using UnityEngine;

public class TouchScreenIvents : MonoBehaviour
{
    [SerializeField] PickZone _pickZone;
    void Update()
    {
        TouchItem();
    }
    private bool TouchItem()
    {
        if (Input.touchCount > 0)

        {
            Touch touch = Input.GetTouch(0);

            // Проверяем, было ли начало касания (TouchPhase.Began)
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);

                RaycastHit hit;
                if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.tag == "Item")
                {

                    _pickZone.selectObject = hit.collider.gameObject;
                    return true;

                }

            }
        }
        return false;
    }
}






