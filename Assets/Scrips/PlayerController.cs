using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float torqueAmount ;

    [SerializeField] float normalSpeed ;

    [SerializeField] float upSpeed ;
    private Rigidbody2D rb2d;

    private SurfaceEffector2D surfaceEffect;
    void Start()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
        this.surfaceEffect = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        SpinPlayer();
        ControlSpeed();
    }

    void SpinPlayer(){
        if(Input.GetKey(KeyCode.LeftArrow)){
            rb2d.AddTorque(torqueAmount);
        }else if (Input.GetKey(KeyCode.RightArrow)){
            rb2d.AddTorque(-torqueAmount);
        }
    }

    void ControlSpeed(){
        if(Input.GetKey(KeyCode.UpArrow)){
            this.surfaceEffect.speed = upSpeed;
        }else{
            this.surfaceEffect.speed = normalSpeed;
        }
    }

     
    
}
