using UnityEngine;
using UnityEngine.EventSystems;

public class BlockThrow : MonoBehaviour, IEndDragHandler
{
    public Rigidbody cubeRigidBody;

    private bool _isPushed = false;

    [SerializeField] private float force = 5.0f;


    public void OnEndDrag(PointerEventData eventData)
    {
        if (!_isPushed)
        {
            cubeRigidBody.AddForce(Vector3.forward * force, ForceMode.Impulse);
            cubeRigidBody.transform.SetParent(null);
            _isPushed = true;
        }
    }

    public void SetNewThrowableBlock(GameObject block)
    {
        cubeRigidBody = block.GetComponent<Rigidbody>();
        _isPushed = false;
    }
}