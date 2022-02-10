using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class BlockSpawner : MonoBehaviour, IEndDragHandler
{
    // Start is called before the first frame update
    [SerializeField] private Transform aimTransform;
    [SerializeField] private GameObject blockPrefab;
    [SerializeField] private float spawnTime = 1.5f;

    private BlockThrow _blockThrow;
    private Coroutine _spawnRoutine;

    private void Start()
    {
        _blockThrow = GetComponent<BlockThrow>();
    }


    public void OnEndDrag(PointerEventData eventData)
    {
        if (_spawnRoutine == null)
            _spawnRoutine = StartCoroutine(DeployCube());
    }

    private IEnumerator DeployCube()
    {
        yield return null;
        yield return new WaitForSeconds(spawnTime);
        GameObject newBlock = Instantiate(blockPrefab, aimTransform.position, Quaternion.identity, aimTransform);

        _blockThrow.SetNewThrowableBlock(newBlock);

        _spawnRoutine = null;
    }
}