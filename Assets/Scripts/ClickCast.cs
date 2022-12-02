using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickCast : MonoBehaviour
{

    [SerializeField] public LayerMask rayLayer;
    private GameObject hitName;
    public float tiempo = 5f;
    public Text textoTimer;
    

    public IEnumerator Contador()
    {
        yield return new WaitForSeconds(1f);
        tiempo--;
        textoTimer.text = tiempo.ToString();
        yield return new WaitForSeconds(1f);
        tiempo--;
        textoTimer.text = tiempo.ToString();
        yield return new WaitForSeconds(1f);
        tiempo--;
        textoTimer.text = tiempo.ToString();
        yield return new WaitForSeconds(1f);
        tiempo--;
        textoTimer.text = tiempo.ToString();
        yield return new WaitForSeconds(1f);
        tiempo--;
        

        CargarEscenas();

    }

    void Update()
    {

        if(Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit2;
            StartCoroutine(Contador());

            if(Physics.Raycast(ray, out hit2, rayLayer))
            {
                Debug.Log(hit2.point);
                transform.position = new Vector3(hit2.point.x, transform.position.y, hit2.point.z);

                hitName = hit2.transform.gameObject;
                Debug.Log(hitName);

            }
        }
    }

    void CargarEscenas()
    {
        if(hitName.gameObject.layer == 6)
        {
            SceneManager.LoadScene("Scene1 1");
        }

        if(hitName.gameObject.layer == 8)
        {
            SceneManager.LoadScene("Scene1 2");
        }

        if(hitName.gameObject.layer == 7)
        {
            SceneManager.LoadScene("Scene1 3");
        }

    }



}
