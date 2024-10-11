using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _maxScale = new Vector3(2f, 2f, 2f);

    private void Update()
    {
        gameObject.transform.localScale = Vector3.Lerp(transform.localScale, _maxScale, _speed * Time.deltaTime);
    }
}
