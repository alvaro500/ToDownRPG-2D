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
        _playerInputReader.MoveEvent += HandleMOve;
    }

    //private void HandleMOve(Vector2 direction)
    private void HandleMOve(Vector2 direction)
    {
        //_moveDirection = direction;

        transform.position += new Vector3(direction.x, direction.y) * _speed; //Time.deltaTime;

        //Debug.Log("En X: "+ direction.x);
        //Debug.Log("En Y: "+ direction.y);
    }

    // Update is called once per frame
    void Update()
    {
        //HandleMOve();
    }
}
