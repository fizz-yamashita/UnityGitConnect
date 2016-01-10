using UnityEngine;
using System.Collections;

// ============================================================
//!		@brief		ステートベースクラス
//!		@note		
//!		@attention	
//!		@warning	
// ============================================================
//public class StateBase
//{
//	private bool mIsPause;// 今のステートが、次のChangeStateで有効になるまで動作させなくする。次の有効で、自動的にfalseにする
//	private bool mInitCalled;// 
//
//	public StateBase() {
//		mIsPause = false;
//	}
//
//	public bool isPause() {
//		return mIsPause;
//	}
//
//	public void pauseEnable() {
//		mIsPause = true;
//	}
//
//	public void pauseDisable() {
//		mIsPause = false;
//	}
//
//	public void _onBeforeInit() {
//		mInitCalled = true;
//		onBeforeInit();
//	}
//
//	public void _onRelease() {
//		mInitCalled = false;
//		onRelease();
//	}
//
//	public bool isInitCalled() {
//		return mInitCalled;
//	}
//
//	void beforeInit() {
//		
//	}
//	bool updateInit(float delta) {
//		return true;
//	}
//	void afterInit() {
//		
//	}
//
//	void beforeMain() {
//		
//	}
//	void updateMain(float delta) {
//	}
//	void afterMain() {
//		
//	}
//
//	void beforeEnd() {
//		
//	}
//	bool updateEnd(float delta) {
//		return true;
//	}
//	void afterEnd() {
//		
//	}
//	void release() {
//		
//	}
//		
//	public void onBeforeInit() {
//		beforeInit();
//	}
//	public bool onUpdateInit(float delta) {
//		return updateInit(delta);
//	}
//	public void onAfterInit() {
//		afterInit();
//	}
//
//	public void onBeforeMain() {
//		beforeMain();
//	}
//	public void onUpdateMain(float delta) {
//		updateMain(delta);
//	}
//	public void onAfterMain() {
//		afterMain();
//	}
//
//	public void onBeforeEnd() {
//		beforeEnd();
//	}
//	public bool onUpdateEnd(float delta) {
//		return updateEnd(delta);
//	}
//	public void onAfterEnd() {
//		afterEnd();
//	}
//
//	public void onRelease() {
//		release();
//	}
//	
//};
