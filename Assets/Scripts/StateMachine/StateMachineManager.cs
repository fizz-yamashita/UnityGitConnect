using UnityEngine;
using System.Collections;

// ============================================================
//!		@brief		ステートマシンマネージャ
//!		@note		シングルトン。ステートマシンの作成、実行、管理
//!		@attention	
//!		@warning	
// ============================================================
//public class StateMachineManager : SingletonBase<StateMachineManager>
//{
//private:
//	Dictionary<STATEMACHINE_NAME, StateMachine> mStateMachineMap; //< ステートマシンのマップ
//
//	public void Awake()
//	{
//		if(this != Instance)
//		{
//			Destroy(this);
//			return;
//		}
//		DontDestroyOnLoad(this.gameObject);
//	}    
//
//	// ============================================================
//	//!		@brief		初期化
//	//!		@note		
//	//!		@return		
//	// ============================================================
//	public void init() {
//	}
//	
//	// ============================================================
//	//!		@brief		ステートマシン作成
//	//!		@note		
//	//!		@return		
//	// ============================================================
//	public void createStateMachineMap() {
//		mStateMachineMap.insert(std::make_pair(STATEMACHINE_NAME::BATTLE,	new StateMachine()));
//		mStateMachineMap.insert(std::make_pair(STATEMACHINE_NAME::NETWORK,	new StateMachine()));
//		mStateMachineMap.insert(std::make_pair(STATEMACHINE_NAME::TEST,		new StateMachine()));
//	}
//		
//	// ============================================================
//	//!		@brief		ステートマシン解放
//	//!		@note		
//	//!		@return		
//	// ============================================================
//	public void release(STATEMACHINE_NAME machineName) {
//		auto it = mStateMachineMap.find(machineName);
//		auto machine = it->second;
//		
//		machine->release();
//	}
//		
//	public void addState(STATEMACHINE_NAME machineName, int stateType, StateBase* state) {
//		auto it = mStateMachineMap.find(machineName);
//		auto machine = it->second;
//		
//		machine->addState(stateType, state);
//	}
//
//	public void changeState(STATEMACHINE_NAME machineName, int stateType) {
//		auto it = mStateMachineMap.find(machineName);
//		auto machine = it->second;
//		
//		machine->changeState(stateType);
//	}
//
//	public void changeStateNowStatePause(STATEMACHINE_NAME machineName, int stateType) {
//		auto it = mStateMachineMap.find(machineName);
//		auto machine = it->second;
//
//		machine->changeStateNowStatePause(stateType);
//	}
//
//	public void update(STATEMACHINE_NAME machineName, float delta) {
//		auto it = mStateMachineMap.find(machineName);
//		auto machine = it->second;
//		
//		machine->update(delta);
//	}
//
//	public int getPrevState(STATEMACHINE_NAME machineName) {
//		auto it = mStateMachineMap.find(machineName);
//		auto machine = it->second;
//
//		return machine->getPrevState();
//	}
//
//	public int getState(STATEMACHINE_NAME machineName) {
//		auto it = mStateMachineMap.find(machineName);
//		auto machine = it->second;
//
//		return machine->getState();
//	}
//};
//
