using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen_Manager : MonoBehaviour
{
    [SerializeField] public GameObject Player;
    [SerializeField] public Camera Cam;
    public Vector3 pPos;
    private bool offScreen;

    // Start is called before the first frame update
    void Start()
    {
        pPos = Player.transform.position;
        offScreen = false;
    }

    // Update is called once per frame
    void Update()
    {
        pPos = Player.transform.position;
        if (Mathf.Abs(pPos.x) > Cam.orthographicSize * Cam.aspect * 1.1f && !offScreen)
        {
            offScreen = true;
            Player.transform.position = new Vector3(pPos.x * -1.05f, pPos.y, pPos.z);
        }

        if (Mathf.Abs(pPos.y) > Cam.orthographicSize * 1.1f && !offScreen)
        {
            offScreen = true;
            Player.transform.position = new Vector3(pPos.x, pPos.y * -1.05f, pPos.z);
        }
        if (-Cam.orthographicSize * Cam.aspect < pPos.x && pPos.x < Cam.orthographicSize * Cam.aspect && -Cam.orthographicSize  < pPos.y && pPos.y < Cam.orthographicSize)
        {
            offScreen = false;
        }
        Debug.Log(string.Format("ScreenX: {0} ScreenY: {1}", Cam.orthographicSize * Cam.aspect, Cam.orthographicSize));
        Debug.Log(string.Format("pPos: {0}, {1} offScreen: {2}", pPos.x,pPos.y, offScreen));
    }

    void GenerateScreen()
    {

    }
}
