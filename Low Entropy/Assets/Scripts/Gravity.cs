using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public List<Rigidbody2D> objects;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        objects.ForEach(d =>
        {
            if(!d.tag.Equals("sun"))
            {
                d.velocity = Random.insideUnitCircle.normalized * Random.value * 10;
            }
            
        });
    }

    // Update is called once per frame
    void Update()
    {
        objects.ForEach(d =>
        {
            objects.ForEach(w =>
            {
                if(d != w)
                {
                    float distance = (d.transform.position - w.transform.position).magnitude;
                    w.AddForce((d.mass * w.mass) * (d.transform.position - w.transform.position) * force * Time.deltaTime / (distance * distance));
                }
            });
        });
    }
}
