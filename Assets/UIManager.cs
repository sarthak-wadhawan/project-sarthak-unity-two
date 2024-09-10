using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Toggle gravityToggle;
    public Slider gravitySlider;
    public Button resetButton;
    public Button randomizeButton;

    private bool isGravityEnabled = true;
    private float gravityStrength = 1f;
    private Rigidbody[] rigidbodies;
    // Start is called before the first frame update
    void Start()
    {
        rigidbodies = FindObjectsOfType<Rigidbody>();


        SetGravity();

        gravityToggle.onValueChanged.AddListener(ToggleGravity);
        gravitySlider.onValueChanged.AddListener(SetGravityStrength);
        resetButton.onClick.AddListener(ResetScene);
        randomizeButton.onClick.AddListener(RandomizeObjects);
    }

    void ToggleGravity(bool isOn)
    {
        isGravityEnabled = isOn;
        SetGravity();
    }

    void SetGravityStrength(float value)
    {
        gravityStrength = value;
        SetGravity();
    }

    void SetGravity()
    {
        if (isGravityEnabled)
        {
            Physics.gravity = new Vector3(0, -gravityStrength, 0);
        }
        else
        {
            Physics.gravity = Vector3.zero;
        }
    }

    void ResetScene()
    {
        // Reset positions of all objects
        foreach (var rb in rigidbodies)
        {
            rb.transform.position = Vector3.zero;
            rb.transform.rotation = Quaternion.identity;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

    void RandomizeObjects()
    {
        foreach (var rb in rigidbodies)
        {
            rb.transform.position = new Vector3(Random.Range(-10f, 10f), Random.Range(0f, 10f), Random.Range(-10f, 10f));
            rb.transform.rotation = Random.rotation;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
