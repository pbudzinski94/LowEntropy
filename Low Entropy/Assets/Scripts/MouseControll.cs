using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControll : MonoBehaviour
{
    public Rigidbody2D object1;
    public Rigidbody2D object2;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Vector2 clickedPlace = Camera.main.ScreenPointToRay(Input.mousePosition).origin;
            Vector2 object2Position = object2.transform.position;
            Vector2 object1Position = object1.transform.position;
            object2.AddForce((clickedPlace - object2Position).normalized * force * Time.deltaTime);
            object1.AddForce((clickedPlace - object1Position).normalized * force * Time.deltaTime);
        }
    }
}
