using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScytheController : MonoBehaviour
{
    public GameObject player;
    private float angle = 0;
    public float damping = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        //this.transform.Rotate(0, -90, angle);
    }

    // Update is called once per frame
    void Update()
    {


        this.transform.position = player.transform.position;

        Vector3 rotatedPoint = Quaternion.AngleAxis(angle, Vector3.forward / 3) * Vector3.left;
        var lookAtPos = Quaternion.LookRotation(player.transform.position);
        this.transform.position += rotatedPoint;
 
        this.transform.Rotate(0, 0, 1);
        angle += 1;

    }
}
