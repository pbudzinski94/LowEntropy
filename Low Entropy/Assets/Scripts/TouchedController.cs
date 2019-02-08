using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class TouchedController : MonoBehaviour
{
    public bool wasTouched = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.GetComponent<TouchedController>() != null && !wasTouched)
        {
            this.wasTouched = true;

        }
        
    }
}
