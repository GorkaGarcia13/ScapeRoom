using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BajarPuerta : MonoBehaviour {
    public Animator PlayerAnim;
	public GameObject puerta;
	public GameObject portal1;
	public GameObject portal2;
    public AudioClip ok;

    AudioSource bien;

    void Start ()
    {

        bien = GetComponent<AudioSource>();
    }

	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		puerta.transform.Translate(Vector3.down * Time.deltaTime * 200);
		portal1.SetActive(false);
        //PlayerAnim.SetBool("Ok", true);
        PlayerAnim.SetTrigger("triggerOK");
        portal2.SetActive(true);
        bien.clip = ok;
        bien.Play();
        //PlayerAnim.SetBool("Ok", false);
        Destroy(this);
        
	}
}
