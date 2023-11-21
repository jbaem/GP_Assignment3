using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject shootPoint;
    public GameObject smallSpider;
    public float spiderDelay;
    public float bulletSide;

    GameObject subSpider1 = null, subSpider2 = null;
    GameObject clone, clone1, clone2;

    private bool spiderFlag = false;

    public ParticleSystem muzzleEffect;

    void OnFire(InputValue value)
    {
        clone = Instantiate(prefab);
        clone.transform.position = shootPoint.transform.position;
        clone.transform.rotation = shootPoint.transform.rotation;


        if (spiderFlag)
        {
            clone1 = Instantiate(clone);
            clone1.transform.Translate(bulletSide, -1, 2);

            clone2 = Instantiate(clone);
            clone2.transform.Translate(-bulletSide, -1, 2);
        }

        muzzleEffect.Play();
    }
    void OnPowerUp(InputValue value)
    {
        if (value.isPressed) spiderFlag = true;
        else spiderFlag = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(spiderFlag)
        {
            subSpider1 = Instantiate(smallSpider);
            subSpider1.transform.position = shootPoint.transform.position;
            subSpider1.transform.rotation = shootPoint.transform.rotation;
            subSpider1.transform.Translate(bulletSide, -1, 2);
            Destroy(subSpider1, spiderDelay);

            subSpider2 = Instantiate(smallSpider);
            subSpider2.transform.position = shootPoint.transform.position;
            subSpider2.transform.rotation = shootPoint.transform.rotation;
            subSpider2.transform.Translate(-bulletSide, -1, 2);
            Destroy(subSpider2, spiderDelay);
        }
    }
}
