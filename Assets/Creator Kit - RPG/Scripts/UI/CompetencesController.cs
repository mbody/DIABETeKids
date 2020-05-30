using System.Collections;
using System.Collections.Generic;
using RPGM.Core;
using RPGM.Gameplay;
using RPGM.UI;
using TMPro;
using UnityEngine;

namespace RPGM.UI
{
	public class CompetencesController : MonoBehaviour
	{
	    SpriteUIElement sizer;
        GameModel model = Schedule.GetModel<GameModel>();

	    // Start is called before the first frame update
	    void Start()
	    {
	      sizer = GetComponent<SpriteUIElement>();
	      Refresh();
	      model.competencesController = this;
	      // A DECLENCHER PAR LA SUITE 
	      //sizer.Show();
	    }

	    // Update is called once per frame
	    public void Refresh()
	    {
	        var displayCount = 0;
            foreach (var i in model.CompetencesItems)
            {
                displayCount++;
            }

            if (displayCount > 0)
                sizer.Show();
            else
                sizer.Hide();
	    }

	}
}
