using UnityEngine;

public class GameManger : MonoBehaviour
{
    #region finding the enemies.
    public GameObject Square;
    public GameObject Circle;
    public GameObject SquareE;
    public GameObject CircleE;
    public float speed = 10f;
    private void Update()
    {
        SquareE = GameObject.Find("SquareEnemy");
        CircleE = GameObject.Find("CircleEnemy");

        float squareDist = Vector2.Distance(Square.transform.position, SquareE.transform.position);
        float circleDist = Vector2.Distance(Circle.transform.position, CircleE.transform.position);

        if (squareDist < 3f)
        {
            SquareE.transform.position = Vector2.MoveTowards(SquareE.transform.position, Square.transform.position, speed * Time.deltaTime);
        }

        if (circleDist < 3f)
        {
            CircleE.transform.position = Vector2.MoveTowards(CircleE.transform.position, Circle.transform.position, speed * Time.deltaTime);
        }

    }
    #endregion

    

}
