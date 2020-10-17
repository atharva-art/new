using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove1();
    }

    void PlayerMove1()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMove = new Vector3(hor, 0f, ver) * Time.deltaTime;
        transform.Translate(playerMove, Space.Self);

    }
}
