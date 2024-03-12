using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leader : MonoBehaviour
{
    public float moveSpeed = 10f; // скорость движения
private CharacterController controller; // ссылка на контроллер персонажа

// Start is called before the first frame update
void Start()
{
    controller = GetComponent<CharacterController>();
}

// Update is called once per frame
void Update()
{
    float moveDirection = 0;
    
    if (Input.GetKey(KeyCode.W))
    {
        moveDirection = moveSpeed;
    }
    else if (Input.GetKey(KeyCode.S))
    {
        moveDirection = -moveSpeed;
    }

    if(moveDirection != 0)
    { 
        Vector3 movePos = new Vector3(0, 0, moveDirection * Time.deltaTime); // вычисляем новое положение
        controller.Move(movePos); // двигаем персонажа
    }
}
}
