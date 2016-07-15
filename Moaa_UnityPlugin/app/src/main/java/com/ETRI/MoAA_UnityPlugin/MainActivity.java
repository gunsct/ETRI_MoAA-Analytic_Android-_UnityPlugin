package com.ETRI.MoAA_UnityPlugin;

import android.app.Activity;

import com.unity3d.player.UnityPlayerActivity;

import kr.re.etri.dtsc.moaa.MobileActivityAnalytics;
import kr.re.etri.dtsc.moaa.common.Market;

import android.content.Intent;
import android.os.Bundle;

public class MainActivity extends UnityPlayerActivity {
    private MobileActivityAnalytics moaa;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //Initialize("643e23c4-4705-11e6-a23f-5626dfb797db", "Google Play");
    }

    public void Initialize(String _APIKey, String _Market ){
        moaa = MobileActivityAnalytics.sharedInstance();
        moaa.setAppInterval(5000);
        moaa.useCellNetwork();
        moaa.initialize(this,_APIKey, _Market);
    }

    public void setAge(int _age){
        moaa.setAge(_age);
    }

    public void setGender(String _gender){
        moaa.setGender(_gender);
    }

    public void useLocationService(){
        moaa.useLocationService();
    }

    public int onAction(String _action, String _label) {
       return moaa.onAction(_action, _label);
    }

    public int onAction(String _action, String _label, long _value) {
        return moaa.onAction(_action, _label, _value);
    }

    public void error(String _errorSummary, String _errorMessage, String _consoleLog) {
        moaa.error(_errorSummary, _errorMessage, _consoleLog);
    }


    //실제로 쓰는지 아닌지 모르는 함수
    public void terminate(){
        moaa.terminate();
    }

    public void getContext(){
        moaa.getContext();
    }

    public void beginActivity(String _className, String _title){
        moaa.beginActivity(_className, _title);
    }

    public void endActivity() {
        moaa.endActivity();
    }

    public void endAction(int _index) {
        moaa.endAction(_index);
    }

    public void onStart(Activity _activity) {
        moaa.onStart(_activity);
    }

    public void onResume(Activity _activity) {
        moaa.onResume(_activity);
    }

    public void onPause(Activity _activity) {
        moaa.onPause(_activity);
    }

    public void onStop(Activity _activity) {
        moaa.onStop(_activity);
    }
}