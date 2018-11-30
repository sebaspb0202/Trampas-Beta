﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ARFC;

public class ManagerNivel1 : MonoBehaviour
{
    GameObject Jugador;
    AudioSource AS_Dialogos;
    public AudioClip AC_Bienvenida;

    private void Start()
    {

        Jugador = GameObject.FindWithTag("Player");
        AS_Dialogos = GameObject.Find("Dialogos").GetComponent<AudioSource>();

        AS_Dialogos.PlayOneShot(AC_Bienvenida);

        StartCoroutine(HabilitarMovimiento(42f));

    }
    // Update is called once per frame
    void Update()
    {

     
    }

    IEnumerator HabilitarMovimiento(float time)
    {

        yield return new WaitForSeconds(time);
         Jugador.GetComponent<FPController>().Constraints.Move = true;
            Jugador.GetComponent<FPController>().Constraints.Jump = false;
            Jugador.GetComponent<FPController>().Constraints.JumpFromAir = false;
            Jugador.GetComponent<FPController>().Constraints.Sprint = !true;
            Jugador.GetComponent<FPController>().Constraints.Crouch = !true;
            Jugador.GetComponent<FPController>().Constraints.Prone =!true;
            Jugador.GetComponent<FPController>().Constraints.Slide = !true;
            Jugador.GetComponent<FPController>().Constraints.Look = !true;
            Jugador.GetComponent<FPController>().Constraints.Lean = !true;
            Jugador.GetComponent<FPController>().Constraints.HeadBob = !true;

    }
}