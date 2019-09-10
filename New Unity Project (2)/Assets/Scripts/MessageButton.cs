using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MessageButton : MonoBehaviour, IPointerClickHandler {

	// Use this for initialization
	void Start () {
        state = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerClick(PointerEventData e)
    {
        Debug.Log("SS");
        state++;
        if (state == 1)
            text.text = "最近好像都沒吃菜...\n我的肥肉好像越來越猖狂ㄌ...";
        else if (state == 2)
            text.text = "為了我的健康著想...\n必須開始維持我的營養均衡 !";
        else if (state == 3)
            text.text = "那就從飲食控制開始好ㄌ...gogogo！";
        else
        {
            Transform f1 = Instantiate(start);
            f1.parent = transform.parent;
            f1.localPosition = new Vector2(0, 0);
            f1.localScale = new Vector3(2, 2, 2);
            Transform f2 = Instantiate(introduction);
            f2.parent = transform.parent;
            f2.localPosition = new Vector2(0, -80);
            f2.localScale = new Vector3(1, 1, 1);
            Destroy(gameObject);
            state = 0;
        }
    }

    private int state;
    public Text text;
    public Transform start;
    public Transform introduction;
}