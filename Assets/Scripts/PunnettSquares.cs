using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ArabicSupport;

public class PunnettSquares : MonoBehaviour
{
	public char firstGeneLetter;
	public  char secondGeneLetter;
    public char thirdGeneLetter;
    public char forthGeneLetter;	

	public Text firstText;
	public Text secondText;
	public Text thirdText;
	public Text forthText;

	public InputField maleGenes;
	public InputField femaleGenes;

	public InputField fullLookGenes;
	public InputField unfullLookGenes;


	public Text output1;
	public Text output2;
	public Text output3;
	public Text output4;	

	public Text output1Desc;
	public Text output2Desc;
	public Text output3Desc;
	public Text output4Desc;

	public Text output1Desc2;
	public Text output2Desc2;
	public Text output3Desc2;
	public Text output4Desc2;

    public Text text1gene;
    public Text text2gene;
    public Text text3gene;
    public Text text4gene;



    int fullgenes;
	int unfullgenes;

	public Text percentage;

	void Start () 
	{
		firstText.enabled = false;
		secondText.enabled = false;
		thirdText.enabled = false;
		forthText.enabled = false;
		output1.enabled = false;
		output1Desc.enabled = false;
		output1Desc2.enabled = false;
		output2.enabled = false;
		output2Desc.enabled = false;
		output2Desc2.enabled = false;
		output3.enabled = false;
		output3Desc.enabled = false;
		output3Desc2.enabled = false;
		output4.enabled = false;
		output4Desc.enabled = false;
		output4Desc2.enabled = false;
		percentage.enabled = false;
	}
	

	void Update () 
	{
		
	}

    public void Match()
    {
        firstGeneLetter = maleGenes.text[0];
        secondGeneLetter = maleGenes.text[1];
        thirdGeneLetter = femaleGenes.text[0];
        forthGeneLetter = femaleGenes.text[1];

  
        if (System.Char.IsLower(firstGeneLetter) == true && System.Char.IsLower(secondGeneLetter) == false)
        {
            percentage.enabled = true;
			percentage.text = "Please Enter the correct genetics.";
			percentage.fontSize = 60;
            return;
        }

        if (System.Char.IsLower(thirdGeneLetter) == true && System.Char.IsLower(forthGeneLetter) == false)
        {
            percentage.enabled = true;
			percentage.text = "Please Enter the correct genetics.";
            percentage.fontSize = 60;
            return;
        }

        text1gene.text = maleGenes.text[0].ToString();
        text2gene.text = maleGenes.text[1].ToString();
        text3gene.text = femaleGenes.text[0].ToString();
        text4gene.text = femaleGenes.text[1].ToString();



        firstText.text = maleGenes.text[0].ToString();
        secondText.text = maleGenes.text[1].ToString();
        thirdText.text = femaleGenes.text[0].ToString();
        forthText.text = femaleGenes.text[1].ToString();

        firstText.enabled = true;
        secondText.enabled = true;
        thirdText.enabled = true;
        forthText.enabled = true;
        output1.enabled = true;
        output1Desc.enabled = true;
        output1Desc2.enabled = true;
        output2.enabled = true;
        output2Desc.enabled = true;
        output2Desc2.enabled = true;
        output3.enabled = true;
        output3Desc.enabled = true;
        output3Desc2.enabled = true;
        output4.enabled = true;
        output4Desc.enabled = true;
        output4Desc2.enabled = true;
        percentage.enabled = true;


        fullgenes = 0;
        unfullgenes = 0;

        #region GenerateGenes


        if (System.Char.IsLower(firstGeneLetter) == true && System.Char.IsLower(thirdGeneLetter) == true)
        {
            output1.text = firstGeneLetter.ToString() + thirdGeneLetter.ToString();
			output1Desc.text = "Recessive gene";
            unfullgenes++;
            output1Desc2.text = unfullLookGenes.text;
        }

        if (System.Char.IsUpper(firstGeneLetter) == true && System.Char.IsUpper(thirdGeneLetter) == true)
        {
            output1.text = firstGeneLetter.ToString() + thirdGeneLetter.ToString();
			output1Desc.text = "Complete dominant gene";
            fullgenes++;
            output1Desc2.text = fullLookGenes.text;
        }

        if (System.Char.IsUpper(firstGeneLetter) == true && System.Char.IsLower(thirdGeneLetter) == true)
        {
            output1.text = firstGeneLetter.ToString() + thirdGeneLetter.ToString();
			output1Desc.text = "Incomplete dominant gene";
            fullgenes++;
            output1Desc2.text = fullLookGenes.text;
        }

        if (System.Char.IsLower(firstGeneLetter) == true && System.Char.IsUpper(thirdGeneLetter) == true)
        {
            output1.text = thirdGeneLetter.ToString() + firstGeneLetter.ToString();
			output1Desc.text = "Incomplete dominant gene";
            fullgenes++;
            output1Desc2.text = fullLookGenes.text;
        }

        if (System.Char.IsLower(secondGeneLetter) == true && System.Char.IsLower(thirdGeneLetter) == true)
        {
            output2.text = secondGeneLetter.ToString() + thirdGeneLetter.ToString();
			output2Desc.text = "Incomplete dominant gene";
            unfullgenes++;
            output2Desc2.text = unfullLookGenes.text;
        }

        if (System.Char.IsUpper(secondGeneLetter) == true && System.Char.IsUpper(thirdGeneLetter) == true)
        {
            output2.text = secondGeneLetter.ToString() + thirdGeneLetter.ToString();
			output2Desc.text = "Complete dominant gene";
            fullgenes++;
            output2Desc2.text = fullLookGenes.text;
        }

        if (System.Char.IsUpper(secondGeneLetter) == true && System.Char.IsLower(thirdGeneLetter) == true)
        {
            output2.text = secondGeneLetter.ToString() + thirdGeneLetter.ToString();
			output2Desc.text = "Incomplete dominant gene";
            fullgenes++;
            output2Desc2.text = fullLookGenes.text;
        }

        if (System.Char.IsLower(secondGeneLetter) == true && System.Char.IsUpper(thirdGeneLetter) == true)
        {
            output2.text = thirdGeneLetter.ToString() + secondGeneLetter.ToString();
			output2Desc.text ="Incomplete dominant gene";
            fullgenes++;
            output2Desc2.text = fullLookGenes.text;
        }

        if (System.Char.IsLower(secondGeneLetter) == true && System.Char.IsLower(forthGeneLetter) == true)
        {
            output3.text = secondGeneLetter.ToString() + forthGeneLetter.ToString();
			output3Desc.text = "Recessive gene";
            unfullgenes++;
            output3Desc2.text = unfullLookGenes.text;
        }

        if (System.Char.IsUpper(secondGeneLetter) == true && System.Char.IsUpper(forthGeneLetter) == true)
        {
            output3.text = secondGeneLetter.ToString() + forthGeneLetter.ToString();
			output3Desc.text = "Complete dominant gene";
            fullgenes++;
            output3Desc2.text = fullLookGenes.text;
        }

        if (System.Char.IsUpper(secondGeneLetter) == true && System.Char.IsLower(forthGeneLetter) == true)
        {
            output3.text = secondGeneLetter.ToString() + forthGeneLetter.ToString();
			output3Desc.text ="Incomplete dominant gene";
            fullgenes++;
            output3Desc2.text = fullLookGenes.text;
        }

        if (System.Char.IsLower(secondGeneLetter) == true && System.Char.IsUpper(forthGeneLetter) == true)
        {
            output3.text = forthGeneLetter.ToString() + secondGeneLetter.ToString();
			output3Desc.text = "Incomplete dominant gene";
            fullgenes++;
            output3Desc2.text = fullLookGenes.text;
        }

        if (System.Char.IsLower(firstGeneLetter) == true && System.Char.IsLower(forthGeneLetter) == true)
        {
            output4.text = firstGeneLetter.ToString() + forthGeneLetter.ToString();
			output4Desc.text = "Recessive gene";
            unfullgenes++;
            output4Desc2.text = unfullLookGenes.text;
        }

        if (System.Char.IsUpper(firstGeneLetter) == true && System.Char.IsUpper(forthGeneLetter) == true)
        {
            output4.text = firstGeneLetter.ToString() + forthGeneLetter.ToString();
			output4Desc.text = "Complete dominant gene";
            fullgenes++;
            output4Desc2.text = fullLookGenes.text;
        }

        if (System.Char.IsUpper(firstGeneLetter) == true && System.Char.IsLower(forthGeneLetter) == true)
        {
            output4.text = firstGeneLetter.ToString() + forthGeneLetter.ToString();
			output4Desc.text = "Incomplete dominant gene";
            fullgenes++;
            output4Desc2.text = fullLookGenes.text;
        }

        if (System.Char.IsLower(firstGeneLetter) == true && System.Char.IsUpper(forthGeneLetter) == true)
        {
            output4.text = forthGeneLetter.ToString() + firstGeneLetter.ToString();
			output4Desc.text = "Incomplete dominant gene";
            fullgenes++;
            output4Desc2.text = fullLookGenes.text;
        }

        if (fullgenes == 4)
        {
            percentage.text = "100% " + "Dominant";
            percentage.fontSize = 95;
        }
        else if (unfullgenes == 4)
        {
            percentage.text = "100% " + "Recessive";
            percentage.fontSize = 95;
        }
        else if (unfullgenes == 2 && fullgenes == 2)
        {
            percentage.text = "1 : 1";
            percentage.fontSize = 95;
        }
        else
        {
            percentage.text = fullgenes.ToString() + " : " + unfullgenes.ToString();
            percentage.fontSize = 95;
        }

        //output1Desc2.text = ArabicFixer.Fix(output1Desc2.text, false, false);
        //output2Desc2.text = ArabicFixer.Fix(output2Desc2.text, false, false);
        //output3Desc2.text = ArabicFixer.Fix(output3Desc2.text, false, false);
        //output4Desc2.text = ArabicFixer.Fix(output4Desc2.text, false, false);
#endregion

     

    }

    public string firstGeneLetter2;
    public string secondGeneLetter2;
    public string thirdGeneLetter2;
    public string forthGeneLetter2;

    public void Reverse()
    {
        if(System.Char.IsUpper(output1.text[0]) == true)
        {
            firstGeneLetter2 = output1.text[0].ToString();
            if(System.Char.IsUpper(output1.text[1]) == true)
            {
                thirdGeneLetter2 = output1.text[1].ToString();
            }
            else if(System.Char.IsUpper(output1.text[1]) == false)
            {
                thirdGeneLetter2 = output1.text[1].ToString();
            }
        }
        else
        {
            firstGeneLetter2 = output1.text[0].ToString();
            thirdGeneLetter2 = output1.text[1].ToString();
        }

        if (System.Char.IsUpper(output2.text[0]) == true)
        {
            secondGeneLetter2 = output2.text[0].ToString();
            if (System.Char.IsUpper(output2.text[1]) == true)
            {
                thirdGeneLetter2 = output2.text[1].ToString();
            }
            else if (System.Char.IsUpper(output2.text[1]) == false)
            {
                thirdGeneLetter2 = output2.text[1].ToString();
            }
        }
        else
        {
            secondGeneLetter2 = output2.text[0].ToString();
            thirdGeneLetter2 = output2.text[1].ToString();
        }
    }

}
