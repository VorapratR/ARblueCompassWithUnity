using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using ZXing;
using ZXing.QrCode;
using System;

public class webCamScript : MonoBehaviour {

    public GameObject webCameraPlane, arrowStraight ,arrrowLeft, arrowRight, arrowBack; 
    public Button fireButton;
    public Text QrCodeLog;
    private WebCamTexture webCameraTexture;
    


    // Use this for initialization
    void Start () {
       
        // GameObject arrowStraight = Instantiate(Resources.Load("arrowStraight", typeof(GameObject))) as GameObject;
        this.arrowStraight = GameObject.FindGameObjectWithTag("arrowStraight");
        this.arrrowLeft = GameObject.FindGameObjectWithTag("arrowLeft");
        this.arrowRight = GameObject.FindGameObjectWithTag("arrowRight");
        this.arrowBack = GameObject.FindGameObjectWithTag("arrowBack");

        this.hideArrow();

        webCameraTexture = new WebCamTexture();
        webCameraPlane.GetComponent<MeshRenderer>().material.mainTexture = webCameraTexture;
        if(webCameraPlane != null)
        {
            webCameraTexture.Play();
        }
    }

    void OnGUI()
    {
        
        // drawing the camera on screen\
        // do the reading — you might want to attempt to read less often than you draw on the screen for performance sake
        try
        {
            IBarcodeReader barcodeReader = new BarcodeReader();
            // decode the current frame
            var result = barcodeReader.Decode(webCameraTexture.GetPixels32(), webCameraTexture.width, webCameraTexture.height);
            if (result != null)
            {
                QrCodeLog.text = result.Text;
                if (result.Text == "1111")
                {
                    this.showArrowStaight();
                }
                else if (result.Text == "2222")
                {
                    this.showArrowBack();
                }
                else if (result.Text == "3333")
                {
                    this.showArrowLeft();
                }
                else if (result.Text == "4444")
                {
                    this.showArrowRight();
                }
                else
                {
                    this.hideArrow();
                }     
            }
        }
        catch (Exception ex) { Debug.LogWarning(ex.Message); }
    }

    void hideArrow()
    {
        // .setActive(false) = hide
        this.arrowStraight.SetActive(false);
        this.arrowBack.SetActive(false);
        this.arrrowLeft.SetActive(false);
        this.arrowRight.SetActive(false);
    }

    void showArrowStaight()
    {
        this.arrowStraight.SetActive(true);
        this.arrowBack.SetActive(false);
        this.arrrowLeft.SetActive(false);
        this.arrowRight.SetActive(false);
    }

    void showArrowBack()
    {
        this.arrowStraight.SetActive(false);
        this.arrowBack.SetActive(true);
        this.arrrowLeft.SetActive(false);
        this.arrowRight.SetActive(false);
    }

    void showArrowLeft()
    {
        this.arrowStraight.SetActive(false);
        this.arrowBack.SetActive(false);
        this.arrrowLeft.SetActive(true);
        this.arrowRight.SetActive(false);
    }

    void showArrowRight()
    {
        this.arrowStraight.SetActive(false);
        this.arrowBack.SetActive(false);
        this.arrrowLeft.SetActive(false);
        this.arrowRight.SetActive(true);
    }

}