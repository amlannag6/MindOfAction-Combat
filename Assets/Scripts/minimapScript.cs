using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimapScript : MonoBehaviour
{
    public Transform Target;

    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = Target.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        transform.rotation = Quaternion.Euler(90f, Target.eulerAngles.y, 0f);
    }
}
