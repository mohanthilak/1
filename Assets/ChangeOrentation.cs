using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOrentation : MonoBehaviour
{
    // Start is called before the first frame update
    int pitchSpeed = 0;
    int yawSpeed = 0;
    int rollSpeed = 0;

    int XtransalationSpeed = 0;
    int YtransalationSpeed = 0;
    int ZtransalationSpeed = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("up")){
            pitchSpeed += 1; 
        }
        if(Input.GetKeyDown("down")){
            pitchSpeed -= 1;
        }
        if(Input.GetKeyDown("right")){
            yawSpeed += 1;
        }
        if(Input.GetKeyDown("left")){
            yawSpeed -= 1;
        }
        if(Input.GetKeyDown("1")){
            rollSpeed -= 1;
        }
        if(Input.GetKeyDown("2")){
            rollSpeed += 1;
        }
        if(Input.GetKeyDown("e")){
            ZtransalationSpeed += 1;
        }
        if(Input.GetKeyDown("q")){
            ZtransalationSpeed -= 1;
        }
        if(Input.GetKeyDown("w")){
            YtransalationSpeed += 1;
        }
        if(Input.GetKeyDown("s")){
            YtransalationSpeed -= 1;
        }
        if(Input.GetKeyDown("d")){
            XtransalationSpeed += 1;
        }
        if(Input.GetKeyDown("a")){
            XtransalationSpeed -= 1;
        }
        transform.Rotate(pitchSpeed*Time.deltaTime,yawSpeed*Time.deltaTime, rollSpeed*Time.deltaTime);
        if(XtransalationSpeed > 0) transform.Translate(Vector3.right * Math.Abs(XtransalationSpeed) * Time.deltaTime);
        if(XtransalationSpeed < 0) transform.Translate(Vector3.left * Math.Abs(XtransalationSpeed) * Time.deltaTime);
        
        if(YtransalationSpeed > 0) transform.Translate(Vector3.up * Math.Abs(YtransalationSpeed) * Time.deltaTime);
        if(YtransalationSpeed < 0) transform.Translate(Vector3.down * Math.Abs(YtransalationSpeed) * Time.deltaTime);
        
        if(ZtransalationSpeed > 0) transform.Translate(Vector3.forward * Math.Abs(ZtransalationSpeed) * Time.deltaTime);
        if(ZtransalationSpeed < 0) transform.Translate(Vector3.back * Math.Abs(ZtransalationSpeed) * Time.deltaTime);


        // transform.Rotate(5*Time.deltaTime,0, 0);
        // if(Input.GetKeyDown("right")){
        //     transform.Rotate(0,20*Time.deltaTime,0);
        // }
        // if(Input.GetKeyDown("left")){
        //     transform.Rotate(0,-2*Time.deltaTime,0);
        // }
        // if(Input.GetKeyDown("down")){
        //     transform.Rotate(2*Time.deltaTime,0,0);
        // }
        // if(Input.GetKeyDown("up")){
        //     transform.Rotate(-2*Time.deltaTime,0,0);
        // }
        // if(Input.GetKeyDown("1")){
        //     transform.Rotate(0,0,2*Time.deltaTime);
        // }
        // if(Input.GetKeyDown("2")){
        //     transform.Rotate(0,0,-2*Time.deltaTime);
        // }
        // if(Input.GetKeyDown("e")){
        //     transform.Translate(Vector3.forward * 50 * Time.deltaTime);
        // }
        // if(Input.GetKeyDown("q")){
        //     transform.Translate(Vector3.back * 50 * Time.deltaTime);
        // }
        // if(Input.GetKeyDown("w")){
        //     transform.Translate(Vector3.up * 50 * Time.deltaTime);
        //     // transform.position += new Vector3(0, 0.2f, 0);
        // }
        // if(Input.GetKeyDown("s")){
        //     transform.Translate(Vector3.down * 50 * Time.deltaTime);
        //     // transform.position += new Vector3(0, -0.2f, 0);
        // }
        // if(Input.GetKeyDown("d")){
        //     transform.Translate(Vector3.right * 50 * Time.deltaTime);
        //     // transform.position += new Vector3(0.2f, 0, 0);
        // }
        // if(Input.GetKeyDown("a")){
        //     transform.Translate(Vector3.left * 50 * Time.deltaTime);

        //     // transform.position += new Vector3(-0.2f, 0, 0);
        // }
        
    }
}
