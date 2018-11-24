using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    private Transform cameraTransform;
    private float speed=0;
    CharacterController player;
    public TMP_Text coordonate;
    // Use this for initialization
    void Start()
    {
        player = gameObject.GetComponent<CharacterController>();
        cameraTransform = Camera.main.transform;
        coordonate.text = "x: " + cameraTransform.position.x.ToString("F2")+"\n"+ "y: " + cameraTransform.position.y.ToString("F2") + "\n" + " z: " + cameraTransform.position.z.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //
        //transform.position += x * cameraTransform.right * speed * Time.deltaTime 
        //     +z * cameraTransform.forward * speed * Time.deltaTime;

        player.SimpleMove(speed * cameraTransform.TransformDirection(Vector3.forward * z
            + Vector3.right * x));
        coordonate.text = "x: " + cameraTransform.position.x.ToString("F2") + "\n" + "y: " + cameraTransform.position.y.ToString("F2") + "\n" + "z: " + cameraTransform.position.z.ToString("F2");
        //bool fire = Input.GetButtonDown("Fire1");
        //if (fire)
        //{
        //    GameObject gmObj = GameObject.Instantiate(proiectil);
        //    gmObj.transform.position = cameraTransform.position + cameraTransform.forward * 5;
        //}

        bool speedDown = Input.GetButtonDown("Fire2");
        if (speedDown)
        {
            speed += 0.1f;
           // speedText.text = "Speed = " + speed;
        }


     


    }
}
