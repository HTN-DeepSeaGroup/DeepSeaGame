using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Darkness_Manager : MonoBehaviour
{
    public float darkness;
    public float[] opacities; 
    public SpriteRenderer[] vignettes;
    public GameObject endText;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        opacities = new float[3];
        vignettes = new SpriteRenderer[3];
        darkness = 0;
        vignettes = GetComponentsInChildren<SpriteRenderer>();
        endText = GameObject.FindGameObjectWithTag("Text");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (darkness > 3600)
        {
            Destroy(player);
            endText.GetComponent<TMPro.TextMeshProUGUI>().color = new Color(1f, 1f, 1f, 1f);
        } 
        opacities[0] = Mathf.Max(0, Mathf.Min(darkness / 1200, 1));
        opacities[1] = Mathf.Max(0, Mathf.Min((darkness-1200) / 1200, 1));
        opacities[2] = Mathf.Max(0, Mathf.Min((darkness-2400) / 1200, 1));
        for (int i = 0; i<3; i++)
        {
            vignettes[i].color = new Color(1f, 1f, 1f, opacities[i]);
        } 
        
        darkness++; 
    }
}
