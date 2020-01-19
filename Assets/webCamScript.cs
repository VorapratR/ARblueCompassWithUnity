using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class webCamScript : MonoBehaviour {

  public GameObject webCameraPlane, arrowStraight ,arrrowLeft, arrowRight; 
  public Button fireButton;


  // Use this for initialization
    void Start () {
       
        // GameObject arrowStraight = Instantiate(Resources.Load("arrowStraight", typeof(GameObject))) as GameObject;
        this.arrowStraight = GameObject.FindGameObjectWithTag("arrowStraight");
        this.arrrowLeft = GameObject.FindGameObjectWithTag("arrowLeft");
        this.arrowRight = GameObject.FindGameObjectWithTag("arrowRight");

        // .setActive(false) = hide
        this.arrowStraight.SetActive(true);
        this.arrrowLeft.SetActive(false);
        this.arrowRight.SetActive(true);

        WebCamTexture webCameraTexture = new WebCamTexture();
        webCameraPlane.GetComponent<MeshRenderer>().material.mainTexture = webCameraTexture;
        webCameraTexture.Play();

  }

}