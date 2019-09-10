using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ResultButton : MonoBehaviour, IPointerClickHandler
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerClick(PointerEventData e)
    {
        if (btn.name == "Button_A")
            result.text = "維生素D：蛋黃、木耳、陽光\n"
                                        + "促進小腸吸收鈣質和磷酸鹽，也有調節骨骼生長的作用。若能補充足夠維生素D，可能降低癌症、心臟病、糖尿病、憂鬱症、及其他免疫疾病的風險，是健康的萬靈丹。";
        if (btn.name == "Button_B")
            result.text = "維生素E：植物油\n"
                                        + "為普遍國人最缺的維生素，有清除自由基的功能，可保護紅血球、肌肉等。若不飽和脂肪吃得多，對維生素E的需求也會提高。缺乏時會有溶血性貧血、運動失調等症狀。";
        if (btn.name == "Button_C")
            result.text = "鉀：水果、海帶、菇類\n"
                                        + "維持細胞間液體平衡，與神經傳導、肌肉收縮、緩解過多的鹽分有關。缺乏時，會有肌肉無力、沒食慾、心律不整等症狀，再嚴重會血壓上升、心血管疾病和中風風險提高。";
        if (btn.name == "Button_D")
            result.text = "鈣：牛奶、蔬菜、豆腐\n"
                                        + "構成骨骼和牙齒的主要成分之一，同時也影響心跳、肌肉、血液、神經等體內多項作用。缺乏時，長期會影響骨骼健康，短期會使神經傳遞出問題，情緒不穩，疲倦、無力。";
        if (btn.name == "Button_E")
            result.text = "鎂：核桃、薏仁、綠色蔬菜\n"
                                        + "構成骨骼、同時也參與體內酸鹼平衡等眾多生理反應。缺乏時，會出現記憶力減退、注意力不集中、失眠、情緒激動、抽筋等現象，亦會增加罹患慢性疾病風險。";
        if (btn.name == "Button_F")
            result.text = "鐵：鴨血、牛肉、魚肉\n"
                                        + "為血紅素中主要元素，與體內能量代謝、免疫功能等有關。缺乏時，會造成組織和器官缺氧，造成容易疲倦、頭暈、臉色蒼白、心跳加快，影響記憶力和學習。";
        if (btn.name == "Button_G")
            result.text = "鋅：堅果、生蠔、肉\n"
                                        + "為體內許多酵素的主成分之一，同時與我們的味覺、生長發育與免疫等多種功能相關。缺乏時，會造成免疫功能異常，容易引發感冒，也與男性生育能力有關。";
        if (btn.name == "Button_H")
            result.text = "碘：海菜、牡蠣\n"
                                        + "為與生長發育有關的甲狀腺素成分之一，可調節體內基礎代謝。缺乏時，會影響甲狀腺功能，體能降低、甲狀腺腫大，婦女懷孕前更需特別注意攝取以免阻礙胎兒腦部發育。";
    }

    public Button btn;
    public Text result;
}
