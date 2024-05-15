using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Code : MonoBehaviour
{
    public Text sayi1t, sayi2t, cevap1, cevap2, cevap3, Score, Zaman;
    public GameObject gameover, oyun, anamenu,pause, credits, nasiloynanir;
    private int score = 0;
    private float zaman = 15;
    private bool but1, but2, but3 = false;

    void Start()
    {
        Calistir();
    }

    void Update()
    {
        Score.text = score.ToString();
        if (oyun.activeSelf == true)
        {
            if (zaman > 0)
            {
                zaman = zaman-Time.deltaTime;
                Zaman.text = zaman.ToString("F1");
            }
            else
            {
                gameover.SetActive(true);
                oyun.SetActive(false);
            }
        }

    }

    void Calistir()
    {
        but1 = false;
        but2 = false;
        but3 = false;

        int sayi1 = Random.Range(0, 100);
        int sayi2 = Random.Range(0, 100);
        sayi1t.text = sayi1.ToString();
        sayi2t.text = sayi2.ToString();

        int a = Random.Range(0, 3);
        if (a == 0)
        {
            but1 = true;
            cevap1.text = (sayi1 + sayi2).ToString();
            cevap2.text = Random.Range(0, 200).ToString();
            cevap3.text = Random.Range(0, 200).ToString();
        }
        else if (a == 1)
        {
            but2 = true;
            cevap1.text = Random.Range(0, 200).ToString();
            cevap2.text = (sayi1 + sayi2).ToString();
            cevap3.text = Random.Range(0, 200).ToString();
        }
        else if (a == 2)
        {
            but3 = true;
            cevap1.text = Random.Range(0, 200).ToString();
            cevap2.text = Random.Range(0, 200).ToString();
            cevap3.text = (sayi1 + sayi2).ToString();
        }
    }
    
    public void Button1Fonk()
    {
        if (but1)
        {
            score += 1;
            Calistir();
        }
        else
        {
            oyun.SetActive(false);
            oyun.SetActive(false);
            gameover.SetActive(true);
        }
        zaman = 15;
    }

    public void Button2Fonk()
    {
        if (but2)
        {
            score += 1;
            Calistir();
        }
        else
        {
            oyun.SetActive(false);
            gameover.SetActive(true);
        }
        zaman = 15;
    }
    public void Button3Fonk()
    {
        if (but3)
        {
            score += 1;
            Calistir();
        }
        else
        {
            oyun.SetActive(false);
            gameover.SetActive(true);
        }
        zaman = 15;
    }

    public void Restartbutton()
    {
        //SceneManager.LoadScene(0);
        zaman = 15;
        score = 0;
        Calistir();
        gameover.SetActive(false);
        oyun.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void AnaMenu()
    {
        credits.SetActive(false);
        nasiloynanir.SetActive(false);
        gameover.SetActive(false);
        oyun.SetActive(false);
        pause.SetActive(false);
        score = 0;
        zaman = 15;
        Calistir();
        anamenu.SetActive(true);
    }
}