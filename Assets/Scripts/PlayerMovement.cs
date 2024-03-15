using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerInputReader _playerInputReader;
    [SerializeField] private float _speed;

    private Vector2 _moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        _playerInputReader.MoveEvent += HandleMove;
    }

    //private void HandleMOve(Vector2 direction)
    private void HandleMove(Vector2 direction)
    {
        _moveDirection = direction;

        //Debug.Log("En X: "+ direction.x);
        //Debug.Log("En Y: "+ direction.y);

        Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Move()
    {
        transform.position += new Vector3(_moveDirection.x, _moveDirection.y) * _speed;
        //transform.position += new Vector3(_moveDirection.x, _moveDirection.y) * (_speed * Time.deltaTime);
    }
}
