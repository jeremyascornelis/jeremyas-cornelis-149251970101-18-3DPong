using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{

    public Collider tembokBawah;
    public Collider tembokAtas;
    public Collider tembokKanan;
    public Collider tembokKiri;

    public ScoreManager manager;

    private void OnTriggerEnter(Collider col)
    {
        if(col == tembokBawah)
        {
            manager.Player1Score(1);
        } else if (col == tembokAtas)
        {
            manager.Player2Score(1);
        } else if (col == tembokKanan)
        {
            manager.Player3Score(1);
        } else if (col == tembokKanan)
        {
            manager.Player3Score(1);
        } else if (col == tembokKiri)
        {
            manager.Player4Score(1);
        }
    }

}
