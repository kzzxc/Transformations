using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private float _growthSpeed;
    [SerializeField] private Vector3 _maxSize;
    
    private Vector3 _defaultSize;
    private Vector3 _targetSize;

    private void Start()
    {
        _defaultSize = transform.localScale;
        _targetSize = _maxSize;
    }

    private void Update()
    {
        ChangeSize();
    }

    private void ChangeSize()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, _targetSize, _growthSpeed * Time.deltaTime);

        if (transform.localScale == _targetSize)
        {
            _targetSize = (_targetSize == _maxSize) ? _defaultSize : _maxSize;
        }
    }
}