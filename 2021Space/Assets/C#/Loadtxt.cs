using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//抓取外部資料
using System.IO;
//使用Unity新的UI程式庫
using UnityEngine.UI;

public class Loadtxt : MonoBehaviour
{
    [Header("讀取中文文字檔案")]
    public string CHMassage;
    [Header("讀取英文文字檔案")]
    public string ENMassage;
    //中文文字檔的路徑
    string CHPath;
    //英文文字檔的路徑
    string ENPath;
    [Header("儲存每行中文文字")]
    public string[] CHTexts;
    [Header("儲存每行英文文字")]
    public string[] ENTexts;

    [Header("讀取該文字在陣列中的代號")]
    public int TextID;

    void Awake()
    {
        //中文文字檔在StreamingAssets資料夾內的路徑
        CHPath = Application.streamingAssetsPath + "/CH.txt";
        //讀取中文文字檔內所有的文字
        CHMassage = File.ReadAllText(CHPath);
        //英文文字檔在StreamingAssets資料夾內的路徑
        ENPath = Application.streamingAssetsPath + "/EN.txt";
        //讀取英文文字檔內所有的文字
        ENMassage = File.ReadAllText(ENPath);
        //Debug.Log(CHMassage);
        //Debug.Log(ENMassage);
        //將字串文字切割 字串.Split('需要切割的符號')
        CHTexts = CHMassage.Split('\n');
        ENTexts = ENMassage.Split('\n');
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //讀取語言下拉選單的ID
        if (Menu.LanguageID==0) {
            //讀取第幾個陣列的中文文字
            GetComponent<Text>().text = CHTexts[TextID];
        }
        if (Menu.LanguageID == 1)
        {
            //讀取第幾個陣列的英文文字
            GetComponent<Text>().text = ENTexts[TextID];
        }
    }
}
