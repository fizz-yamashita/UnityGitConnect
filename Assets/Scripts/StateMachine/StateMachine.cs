using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//enum MACHINE_STATE : int
//{
//	NONE,
//	BEFORE_INIT,
//	UPDATE_INIT,
//	AFTER_INIT,
//	BEFORE_MAIN,
//	UPDATE_MAIN,
//	AFTER_MAIN,
//	BEFORE_END,
//	UPDATE_END,
//	AFTER_END,
//	RELEASE	
//};
//
//// ============================================================
////!		@brief		ステートマネージャ
////!		@note		シングルトン。ステートの切り替え、管理をする
////!		@attention	
////!		@warning	
//// ============================================================
//public class StateMachine {
//	
//	private StateBase mNowState;
//	private MACHINE_STATE mManageState;
//	private int mState;
//	private int mNextState;
//	private int mPrevState;
//
//	private Dictionary<int, StateBase> mStateMap;
//
//	public void init(){
//		mNowState       = null;
//		mManageState	= MACHINE_STATE.NONE;
//		mState			= 0;
//		mNextState 		= 0;
//		mPrevState 		= 0;
//	
//		mStateMap		= new Dictionary<int, StateBase>();
//	}
//	
//	public void update(float delta){
//		if(mNowState == null)
//		{
//			return;
//		}
//
//		switch(mManageState)
//		{
//		case (int)MACHINE_STAME.BEFORE_INIT:
//			if (mNowState.isPause() == true)
//			{
//				// ポーズ状態だったら、即メインのアップデート処理状態にする
//				mManageState = MACHINE_STAME.UPDATE_MAIN;
//				mNowState.pauseDisable();
//			}
//			else
//			{
//				mManageState = MACHINE_STAME.UPDATE_INIT;
//				mNowState._onBeforeInit();
//			}
//			break;
//		
//		case (int)MACHINE_STAME.UPDATE_INIT:
//			{
//				bool isEnd = mNowState.onUpdateInit(delta);
//				if(isEnd == true)
//				{
//					mManageState = MACHINE_STAME.AFTER_INIT;
//				}
//			}
//			break;
//		
//		case (int)MACHINE_STAME.AFTER_INIT:
//			mManageState = MACHINE_STAME.BEFORE_MAIN;
//			mNowState.onAfterInit();
//			break;
//		
//		case (int)MACHINE_STAME.BEFORE_MAIN:
//			mManageState = MACHINE_STAME.UPDATE_MAIN;
//			mNowState.onBeforeMain();
//			break;
//		
//		case (int)MACHINE_STAME.UPDATE_MAIN:
//			mNowState.onUpdateMain(delta);
//			break;
//		
//		case (int)MACHINE_STAME.AFTER_MAIN:
//			mManageState = MACHINE_STAME.BEFORE_END;
//			mNowState.onAfterMain();
//			break;
//		
//		case (int)MACHINE_STAME.BEFORE_END:
//			mManageState = MACHINE_STAME.UPDATE_END;
//			mNowState.onBeforeEnd();
//			break;
//		
//		case (int)MACHINE_STAME.UPDATE_END:
//			{
//				bool isEnd = mNowState.onUpdateEnd(delta);
//				if(isEnd == true)
//				{
//					mManageState = MACHINE_STAME.AFTER_END;
//				}
//			}
//			break;
//		
//		case (int)MACHINE_STAME.AFTER_END:
//			mManageState = MACHINE_STAME.RELEASE;
//			mNowState.onAfterEnd();
//			break;
//		
//		case (int)MACHINE_STAME.RELEASE:
//			{
//				mManageState = MACHINE_STAME.BEFORE_INIT;
//				if (mNowState.isPause() != true)
//				{
//					mNowState._onRelease();
//				}
//				mPrevState = mState;
//				mState = mNextState;
//				auto it = mStateMap.find(mState);
//				mNowState = it.second;
//				break;
//			}
//		}
//	}
//	
//	public void release(){
//
//		foreach(var it in mStateMap)
//		{
//			if(it.second.isInitCalled() == true)
//			{
//				it.second._onRelease();
//			}
//			it.second = null;
//		}
//
//		mStateMap.Clear();
//		mNowState = null;
//	}
//	
//	public void changeState(int stateValue){
//		if (mManageState != MACHINE_STAME.AFTER_INIT &&
//			mManageState != MACHINE_STAME.UPDATE_MAIN		)
//		{
//			log("StateMachine::changeState");
//			log("%d state isnt use changeState", (int)mManageState);
//			CCASSERT(true, "changeState assert");
//		}
//
//		if(mNowState != null)
//		{
//			mNextState = stateType;
//			mManageState = MACHINE_STAME.AFTER_MAIN;
//		}
//		else
//		{
//			auto it = mStateMap.find(stateType);
//			mNowState = it.second;
//			mManageState = MACHINE_STAME.BEFORE_INIT;
//		}
//	}
//	
//	public void changeStateNowStatePause(int stateValue){
//		if (mManageState != MACHINE_STAME.AFTER_INIT &&
//			mManageState != MACHINE_STAME.UPDATE_MAIN)
//		{
//			log("StateMachine::changeState");
//			log("%d state isnt use changeState", (int)mManageState);
//			CCASSERT(true, "changeState assert");
//		}
//
//		if(mNowState != null)
//		{
//			mNowState.pauseEnable();
//			mNextState = stateType;
//			mManageState = MACHINE_STAME.RELEASE;// 即リリース状態にしているが、PAUSEをかけているので、リリースの処理は呼び出されない
//		}
//		else
//		{
//			auto it = mStateMap.find(stateType);
//			mNowState = it.second;
//			mManageState = MACHINE_STAME.BEFORE_INIT;
//		}
//	}
//
//	public void addState(int stateType, StateBase state){
//		auto findIt = mStateMap.find(stateType);
//		if(findIt != mStateMap.end())
//		{
//			return;
//		}
//
//		mStateMap.insert(std::make_pair(stateType, state));
//	}
//	
//	public int getState(){
//		return mState;
//	}
//	
//	public int getPrevState(){
//		return mPrevState;
//	}
//}
