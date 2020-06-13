using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour
{
    
    public GameObject[] Tools;
    private List<GameObject> Elems=new List<GameObject>();
    public int tool = 0;//0 and more
    public int[] numberDinamite;
    public float WaitTime=0.1f;
    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Detonate()
    {
        if (Elems.Count>0)
        {
            StartCoroutine(Explose());
        }
    }
    public void Install(Vector2 lm)
    {
        if (numberDinamite[tool] > 0) {

            Elems.Add(Instantiate(Tools[tool], lm, Quaternion.identity));
            numberDinamite[tool]--;

        }
    }
    public void Restart()
    {
        SceneController.RestartScene();
    }
    public void SceneLoad(string sceneName)
    {
        SceneController.OpenScene(sceneName);
    }

    IEnumerator Explose()
    {
        foreach(var elem in Elems)
        {
            elem.GetComponent<Dinamite>().Detonate();
            yield return new WaitForSeconds(WaitTime);
        }
        Elems.Clear();
        yield return new WaitForSeconds(2f);
        if (numberDinamite[tool] == 0)
        {
            //yield return new WaitForSeconds();
            FindObjectOfType<ScoreCounter>().Activate();
        }
        StopAllCoroutines();
    }
    public void SetTool(int index)
    {
        if (index < Tools.Length) tool = index;
    }
}
