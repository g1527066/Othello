using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum TroutType
{
    Black,
    White,
    None,
}

struct Point
{
   public int x;
   public int y;
}

public class Board : MonoBehaviour
{
    //---------------------------------------------------------------
    //一旦位置調整中
    //---------------------------------------------------------------

    const int TroutNumber = 8;

    Dictionary<Point, Stone> stoneTable = new Dictionary<Point, Stone>();

    [SerializeField]
    Stone stonePrefab = null;

    //左上
    Vector3 ReferencePosition = new Vector3(-4.25f,0.35f,4.25f);

    const float TroutInterval = 1.2f;

    void Start()
    {
        for(int i=0;i<TroutNumber;i++)
        {
            for (int j = 0; j < TroutNumber; j++)
            {
                Point point;
                point.x = i;
                point.y = j;

                GenerationTrout(point);
            }
        }
        

    }

    void GenerationTrout(Point generationPoint)
    {
        Stone s = Instantiate(stonePrefab,this.transform);
        s.transform.position =ReferencePosition+new Vector3(generationPoint.x*TroutInterval,0, -generationPoint.y * TroutInterval);
    }

    void Update()
    {

    }
}
