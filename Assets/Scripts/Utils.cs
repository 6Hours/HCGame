using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour
{
    
    private GameObject Example;
    public int tool = 1;
    public int numberDinamite = 1;
    public float sizeModificator=1f;
    // Start is called before the first frame update
    void Start()
    {
        Example = FindObjectOfType<Dinamite>().gameObject;


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Detonate()
    {
        if (Example != null)
        {
            var dinams = FindObjectsOfType<Dinamite>();
            for (int i = 0; i < dinams.Length; i++)
            {
                dinams[i].Detonate();
            }
        }
    }
    public void Install(Vector2 lm)
    {
        if (numberDinamite > 0&&Example!=null) {

            //Camera cam = FindObjectOfType<Camera>();
            //if (Physics2D.Raycast(cam.transform.position, new Vector3())
            //{
            //    RaycastHit2D hit=Physics2D.Raycast(cam.transform.position, Input.mousePosition);
            //    Vector2 lm = new Vector2(hit.point.x, hit.point.y);
            //    Instantiate(Example, lm, Quaternion.identity);
            //    numberDinamite--;
            //}

            
            Instantiate(Example, lm, Quaternion.identity);
            numberDinamite--;

            //Vector2 lm = new Vector2(-3f+Input.mousePosition.x*sizeModificator, -3.6f+Input.mousePosition.y*sizeModificator);
            //Instantiate(Example, lm, Quaternion.identity);
            //numberDinamite--;
        }
    }
    public void Restart()
    {
        SceneController.RestartScene();
    }
    public void GoMenu()
    {
        SceneController.OpenScene("Start");
    }
    IEnumerator InstallDinamite()
    {
        Vector2 lm = new Vector2(Input.mousePosition.x * sizeModificator, Input.mousePosition.y * sizeModificator);
        Instantiate(Example, lm, Quaternion.identity);
        numberDinamite--;
        yield return new WaitForSeconds(1f);

    }
}
