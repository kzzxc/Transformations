using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(0f, _speed * Time.deltaTime,0f);
    }
}
