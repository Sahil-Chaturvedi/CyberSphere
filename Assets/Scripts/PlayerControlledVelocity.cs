using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControlledVelocity : MonoBehaviour
{

    [SerializeField]
    Vector3 v3force;

    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;

    public Image levelSplash;
    public AudioSource playersounds;
    public AudioClip winSound;
    // Update is called once per frame
    void FixedUpdate()
    {   
        if (Input.GetKey(keyPositive))
            GetComponent<Rigidbody>().velocity += v3force;
        if (Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -= v3force;
        
    }
    public void BeatLevel()
    {
        levelSplash.gameObject.SetActive(true);
        playersounds.PlayOneShot(winSound);
    }
}
