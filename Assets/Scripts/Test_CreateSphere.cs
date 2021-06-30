using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Test_CreateSphere : MonoBehaviour
{
    private int count_spheres = 0;
    Dictionary<string, GameObject> spheres = new Dictionary<string, GameObject>();
    public 
    // Start is called before the first frame update
    void Start()
    {
        introduce14spheres();
    }

    private GameObject createSphere()
    {
        GameObject sphere_aux;
        sphere_aux = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere_aux.GetComponent<Renderer>().material.color = Color.red;
        sphere_aux.transform.position = new Vector3(0.0f, 5.0f, -20.0f);
        sphere_aux.transform.localScale = new Vector3(3, 3, 3);
        sphere_aux.GetComponent<SphereCollider>().enabled = true;
        sphere_aux.AddComponent<ChangeColor>().enabled = true;
        sphere_aux.AddComponent<EventTrigger>().enabled = true;
        EventTrigger trigger = sphere_aux.GetComponent<EventTrigger>();
        EventTrigger.Entry entry_click = new EventTrigger.Entry();
        entry_click.eventID = EventTriggerType.PointerClick;
        entry_click.callback.AddListener((data) => { OnPointerClicked(sphere_aux); });
        trigger.triggers.Add(entry_click);

        EventTrigger.Entry entry_enter = new EventTrigger.Entry();
        entry_enter.eventID = EventTriggerType.PointerEnter;
        entry_enter.callback.AddListener((data) => { OnPointerEnter(sphere_aux); });
        trigger.triggers.Add(entry_enter);

        return sphere_aux;
    }

    private void introduce14spheres()
    {
        while (count_spheres < 14)
        {
            count_spheres++;
            Debug.Log(count_spheres);
            spheres.Add("sphere" + count_spheres, createSphere());
        }
    }

    private void OnPointerClicked(GameObject sphere_aux)
    {
        sphere_aux.transform.localScale = new Vector3(1, 1, 1);
        Debug.Log("OnPointerClicked called.");
    }

    private void OnPointerEnter(GameObject sphere_aux)
    {
        sphere_aux.GetComponent<ChangeColor>().White();
        Debug.Log("OnPointerEnter called.");
    }
}
