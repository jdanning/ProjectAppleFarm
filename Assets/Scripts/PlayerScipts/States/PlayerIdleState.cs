﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerIdleState : PlayerBaseState
{

    private PlayerController playerController;


    public PlayerIdleState(PlayerController _playerController) : base(_playerController.gameObject) {
        playerController = _playerController;
    }


    public override void Enter(){
        //enter anim
    }


    public override Type Tick() {
        if(playerController.playerDash){
            
            return(typeof(PlayerDashState));
        }
        if(playerController.playerBasicAttack) {
            //playerController.playerBasicAttack = false;
            return(typeof(BasicHitState_0));
        }
       
        //do idle anim
        return null;
    }

    public override void PhysicsTick()
    {
        playerController.doMovement(1f);
        playerController.doRotation(1f);
    }

    public override void Exit(){
        //exit anim
    }
}
