using TMPro;
using UnityEngine;

public class UIComponents : MonoBehaviour
{
    [SerializeField] TMP_Text header;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeText()
    {
        header.text = "HELLO";
    }

    public void DestroyCanvas()
    {
        Destroy(gameObject);
    }
}
