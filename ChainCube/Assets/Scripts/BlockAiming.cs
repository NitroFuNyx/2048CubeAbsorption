using UnityEngine;
using UnityEngine.EventSystems;

public class BlockAiming : MonoBehaviour, IDragHandler
{
    // Start is called before the first frame update
    public Transform leftMaxPos;
    public Transform rightMaxPos;
    public Transform aimPoint;
    public float sensitivity = 3.0f;


    public void OnDrag(PointerEventData eventData)
    {
        if (Mathf.Abs(eventData.delta.x) > 0)
        {
            aimPoint.transform.position += new Vector3(Time.deltaTime * sensitivity * eventData.delta.x, 0f, 0f);

            if (aimPoint.transform.position.x > rightMaxPos.position.x)
                aimPoint.transform.position = rightMaxPos.transform.position;

            else if (aimPoint.transform.position.x < leftMaxPos.position.x)
                aimPoint.transform.position = leftMaxPos.transform.position;
        }
    }
}